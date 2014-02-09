-- Creating table 'Reports'
CREATE TABLE [dbo].[Reports] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [PostId] int  NOT NULL,
	   [ReportReasonId] int  NOT NULL,
	   [DateCreated] datetime2  NOT NULL,
	   [OtherReason] nvarchar(max)  NULL
);
GO
-- Creating foreign key on [PostId] in table 'Reports'
ALTER TABLE [dbo].[Reports]
ADD CONSTRAINT [FK_PostReport]
    FOREIGN KEY ([PostId])
    REFERENCES [dbo].[Posts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating foreign key on [ReportReasonId] in table 'Reports'
ALTER TABLE [dbo].[Reports]
ADD CONSTRAINT [FK_ReportReasonReport]
    FOREIGN KEY ([ReportReasonId])
    REFERENCES [dbo].[ReportReasons]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating primary key on [Id] in table 'Reports'
ALTER TABLE [dbo].[Reports]
ADD CONSTRAINT [PK_Reports]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_PostReport'
CREATE INDEX [IX_FK_PostReport]
ON [dbo].[Reports]
    ([PostId]);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_ReportReasonReport'
CREATE INDEX [IX_FK_ReportReasonReport]
ON [dbo].[Reports]
    ([ReportReasonId]);