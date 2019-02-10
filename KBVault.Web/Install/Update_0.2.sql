USE [kbvault]
GO
ALTER TABLE [dbo].[Article] ADD [LastAuthorEdited] bigint NOT NULL DEFAULT 1
ALTER TABLE [dbo].[Article] DROP [SefName]
ALTER TABLE [dbo].[Category] DROP [SefName]

USE [kbvault]
GO
/****** Object:  StoredProcedure [dbo].[GetSimilarArticles]    Script Date: 10/2/2019 11:42:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Version 0.31 --

ALTER PROCEDURE [dbo].[GetSimilarArticles]
	@ArticleId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Select  Top 5	t.Id ,t.Title,t.PublishEndDate, t.PublishStartDate,t.IsDraft,
					sum(Relevance) as Relevance 
	From ( 
			select	ArticleId,
					TagId, 
					(
						Select Count(*) from ArticleTag i 
						Where i.ArticleId = @ArticleId and TagId = o.TagId
					) Relevance 
			from ArticleTag o 
			where ArticleId <>  @ArticleId
		  ) x 
	left join Article t on x.ArticleId = t.Id 
	group by t.Id ,t.Title,t.PublishEndDate, t.PublishStartDate,t.IsDraft
	having sum(Relevance) > 0 
	order by sum(Relevance) desc  

END