repo.RemoveAllByKey(repo.Items.Where(x => x.ID < 0).Select(x => new object[] { x.ID }));
