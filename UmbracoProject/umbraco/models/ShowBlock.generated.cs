//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v9.2.0+763cb70e677ac0c85557b19b5df09eccfa1b9dfb
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
	// Mixin Content Type with alias "showBlock"
	/// <summary>Show Block</summary>
	public partial interface IShowBlock : IPublishedElement
	{
		/// <summary>Show Component</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.2.0+763cb70e677ac0c85557b19b5df09eccfa1b9dfb")]
		bool ShowComponent { get; }
	}

	/// <summary>Show Block</summary>
	[PublishedModel("showBlock")]
	public partial class ShowBlock : PublishedElementModel, IShowBlock
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.2.0+763cb70e677ac0c85557b19b5df09eccfa1b9dfb")]
		public new const string ModelTypeAlias = "showBlock";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.2.0+763cb70e677ac0c85557b19b5df09eccfa1b9dfb")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.2.0+763cb70e677ac0c85557b19b5df09eccfa1b9dfb")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.2.0+763cb70e677ac0c85557b19b5df09eccfa1b9dfb")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<ShowBlock, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public ShowBlock(IPublishedElement content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Show Component: If the switch is on, then the element or block will be displayed for users
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.2.0+763cb70e677ac0c85557b19b5df09eccfa1b9dfb")]
		[ImplementPropertyType("showComponent")]
		public virtual bool ShowComponent => GetShowComponent(this, _publishedValueFallback);

		/// <summary>Static getter for Show Component</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.2.0+763cb70e677ac0c85557b19b5df09eccfa1b9dfb")]
		public static bool GetShowComponent(IShowBlock that, IPublishedValueFallback publishedValueFallback) => that.Value<bool>(publishedValueFallback, "showComponent");
	}
}
