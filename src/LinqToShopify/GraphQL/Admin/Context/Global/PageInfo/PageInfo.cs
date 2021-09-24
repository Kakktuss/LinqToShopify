﻿using LinqToGraphQL.Attributes;

namespace LinqToShopify.GraphQL.Admin.Context.Global.PageInfo
{
	public class PageInfo
	{
		
		[GraphName("hasNextPage")]
		public bool HasNextPage { get; set; }
		
		[GraphName("hasPreviousPage")]
		public bool HasPreviousPage { get; set; }
		
	}
}