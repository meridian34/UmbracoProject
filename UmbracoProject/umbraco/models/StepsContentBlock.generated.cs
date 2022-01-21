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
	/// <summary>Steps Content Block</summary>
	[PublishedModel("stepsContentBlock")]
	public partial class StepsContentBlock : PublishedElementModel, IButtonContentBlock, ILinkContentBlock, IShowBlock, ITextContentBlock
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.2.0+763cb70e677ac0c85557b19b5df09eccfa1b9dfb")]
		public new const string ModelTypeAlias = "stepsContentBlock";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.2.0+763cb70e677ac0c85557b19b5df09eccfa1b9dfb")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.2.0+763cb70e677ac0c85557b19b5df09eccfa1b9dfb")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.2.0+763cb70e677ac0c85557b19b5df09eccfa1b9dfb")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<StepsContentBlock, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public StepsContentBlock(IPublishedElement content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// StepsList
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.2.0+763cb70e677ac0c85557b19b5df09eccfa1b9dfb")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("stepsList")]
		public virtual global::Umbraco.Cms.Core.Models.Blocks.BlockListModel StepsList => this.Value<global::Umbraco.Cms.Core.Models.Blocks.BlockListModel>(_publishedValueFallback, "stepsList");

		///<summary>
		/// Button Bind: The URL attached to this button
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.2.0+763cb70e677ac0c85557b19b5df09eccfa1b9dfb")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("buttonBind")]
		public virtual string ButtonBind => global::Umbraco.Cms.Web.Common.PublishedModels.ButtonContentBlock.GetButtonBind(this, _publishedValueFallback);

		///<summary>
		/// Button Text: The text to be displayed on the button
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.2.0+763cb70e677ac0c85557b19b5df09eccfa1b9dfb")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("buttonText")]
		public virtual string ButtonText => global::Umbraco.Cms.Web.Common.PublishedModels.ButtonContentBlock.GetButtonText(this, _publishedValueFallback);

		///<summary>
		/// Linked Url: The URL or relative link that will be attached to the link element for navigation
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.2.0+763cb70e677ac0c85557b19b5df09eccfa1b9dfb")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("linkedUrl")]
		public virtual string LinkedUrl => global::Umbraco.Cms.Web.Common.PublishedModels.LinkContentBlock.GetLinkedUrl(this, _publishedValueFallback);

		///<summary>
		/// Link Text: The text that will be displayed on the link element
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.2.0+763cb70e677ac0c85557b19b5df09eccfa1b9dfb")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("linkText")]
		public virtual string LinkText => global::Umbraco.Cms.Web.Common.PublishedModels.LinkContentBlock.GetLinkText(this, _publishedValueFallback);

		///<summary>
		/// Show Component: If the switch is on, then the element or block will be displayed for users
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.2.0+763cb70e677ac0c85557b19b5df09eccfa1b9dfb")]
		[ImplementPropertyType("showComponent")]
		public virtual bool ShowComponent => global::Umbraco.Cms.Web.Common.PublishedModels.ShowBlock.GetShowComponent(this, _publishedValueFallback);

		///<summary>
		/// Text Block Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.2.0+763cb70e677ac0c85557b19b5df09eccfa1b9dfb")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("textBlockDescription")]
		public virtual string TextBlockDescription => global::Umbraco.Cms.Web.Common.PublishedModels.TextContentBlock.GetTextBlockDescription(this, _publishedValueFallback);

		///<summary>
		/// Text Block Subtitle: Subtitle for text block content
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.2.0+763cb70e677ac0c85557b19b5df09eccfa1b9dfb")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("textBlockSubtitle")]
		public virtual string TextBlockSubtitle => global::Umbraco.Cms.Web.Common.PublishedModels.TextContentBlock.GetTextBlockSubtitle(this, _publishedValueFallback);

		///<summary>
		/// Text Block Title: Title for text block content
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.2.0+763cb70e677ac0c85557b19b5df09eccfa1b9dfb")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("textBlockTitle")]
		public virtual string TextBlockTitle => global::Umbraco.Cms.Web.Common.PublishedModels.TextContentBlock.GetTextBlockTitle(this, _publishedValueFallback);
	}
}