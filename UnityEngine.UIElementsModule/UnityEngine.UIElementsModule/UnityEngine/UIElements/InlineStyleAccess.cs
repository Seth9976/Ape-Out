using System;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements
{
	// Token: 0x02000116 RID: 278
	public class InlineStyleAccess : StyleValueCollection
	{
		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x0600066B RID: 1643 RVA: 0x00006860 File Offset: 0x00004A60
		// (set) Token: 0x0600066C RID: 1644 RVA: 0x0000686D File Offset: 0x00004A6D
		public VisualElement ve
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x0000687A File Offset: 0x00004A7A
		public override void Finalize()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x00006887 File Offset: 0x00004A87
		public void SetInlineRule(StyleSheet sheet, StyleRule rule)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x00006894 File Offset: 0x00004A94
		public void ApplyInlineStyles(ComputedStyle sharedStyle)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000670 RID: 1648 RVA: 0x0000C750 File Offset: 0x0000A950
		// (set) Token: 0x06000671 RID: 1649 RVA: 0x0000C780 File Offset: 0x0000A980
		public StyleCursor UnityEngine.UIElements.IStyle.cursor
		{
			get
			{
				StyleCursor styleCursor = default(StyleCursor);
				bool flag = this.TryGetInlineCursor(ref styleCursor);
				StyleCursor styleCursor2;
				if (flag)
				{
					styleCursor2 = styleCursor;
				}
				else
				{
					styleCursor2 = StyleKeyword.Null;
				}
				return styleCursor2;
			}
			set
			{
				bool flag = this.SetInlineCursor(value, this.ve.sharedStyle.cursor);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles);
				}
			}
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x000068A1 File Offset: 0x00004AA1
		public bool SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, StyleLength inlineValue, StyleLength sharedValue)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x000068AE File Offset: 0x00004AAE
		public bool SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, StyleColor inlineValue, StyleColor sharedValue)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x000068BB File Offset: 0x00004ABB
		public bool SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, StyleBackground inlineValue, StyleBackground sharedValue)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x000068C8 File Offset: 0x00004AC8
		public bool SetInlineCursor(StyleCursor inlineValue, StyleCursor sharedValue)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x000068D5 File Offset: 0x00004AD5
		public bool TryGetInlineCursor(ref StyleCursor value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x000068E2 File Offset: 0x00004AE2
		public void SetInlineCursor(StyleCursor value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000678 RID: 1656 RVA: 0x0000C7BC File Offset: 0x0000A9BC
		// (set) Token: 0x06000679 RID: 1657 RVA: 0x0000C7DC File Offset: 0x0000A9DC
		public StyleColor UnityEngine.UIElements.IStyle.backgroundColor
		{
			get
			{
				return base.GetStyleColor(UnityEngine.UIElements.StyleSheets.StylePropertyId.BackgroundColor);
			}
			set
			{
				bool flag = this.SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId.BackgroundColor, value, this.ve.sharedStyle.backgroundColor);
				if (flag)
				{
					this.ve.IncrementVersion((VersionChangeType)2080);
				}
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x0600067A RID: 1658 RVA: 0x0000C820 File Offset: 0x0000AA20
		// (set) Token: 0x0600067B RID: 1659 RVA: 0x0000C840 File Offset: 0x0000AA40
		public StyleBackground UnityEngine.UIElements.IStyle.backgroundImage
		{
			get
			{
				return base.GetStyleBackground(UnityEngine.UIElements.StyleSheets.StylePropertyId.BackgroundImage);
			}
			set
			{
				bool flag = this.SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId.BackgroundImage, value, this.ve.sharedStyle.backgroundImage);
				if (flag)
				{
					this.ve.IncrementVersion((VersionChangeType)2080);
				}
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x0600067C RID: 1660 RVA: 0x0000C884 File Offset: 0x0000AA84
		// (set) Token: 0x0600067D RID: 1661 RVA: 0x0000C8A4 File Offset: 0x0000AAA4
		public StyleColor UnityEngine.UIElements.IStyle.borderBottomColor
		{
			get
			{
				return base.GetStyleColor(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderBottomColor);
			}
			set
			{
				bool flag = this.SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderBottomColor, value, this.ve.sharedStyle.borderBottomColor);
				if (flag)
				{
					this.ve.IncrementVersion((VersionChangeType)2080);
				}
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x0600067E RID: 1662 RVA: 0x0000C8E8 File Offset: 0x0000AAE8
		// (set) Token: 0x0600067F RID: 1663 RVA: 0x0000C908 File Offset: 0x0000AB08
		public StyleLength UnityEngine.UIElements.IStyle.borderBottomLeftRadius
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderBottomLeftRadius);
			}
			set
			{
				bool flag = this.SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderBottomLeftRadius, value, this.ve.sharedStyle.borderBottomLeftRadius);
				if (flag)
				{
					this.ve.IncrementVersion((VersionChangeType)2208);
				}
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000680 RID: 1664 RVA: 0x0000C94C File Offset: 0x0000AB4C
		// (set) Token: 0x06000681 RID: 1665 RVA: 0x0000C96C File Offset: 0x0000AB6C
		public StyleLength UnityEngine.UIElements.IStyle.borderBottomRightRadius
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderBottomRightRadius);
			}
			set
			{
				bool flag = this.SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderBottomRightRadius, value, this.ve.sharedStyle.borderBottomRightRadius);
				if (flag)
				{
					this.ve.IncrementVersion((VersionChangeType)2208);
				}
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000682 RID: 1666 RVA: 0x0000C9B0 File Offset: 0x0000ABB0
		// (set) Token: 0x06000683 RID: 1667 RVA: 0x0000C9D0 File Offset: 0x0000ABD0
		public StyleColor UnityEngine.UIElements.IStyle.borderLeftColor
		{
			get
			{
				return base.GetStyleColor(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderLeftColor);
			}
			set
			{
				bool flag = this.SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderLeftColor, value, this.ve.sharedStyle.borderLeftColor);
				if (flag)
				{
					this.ve.IncrementVersion((VersionChangeType)2080);
				}
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000684 RID: 1668 RVA: 0x0000CA14 File Offset: 0x0000AC14
		// (set) Token: 0x06000685 RID: 1669 RVA: 0x0000CA34 File Offset: 0x0000AC34
		public StyleColor UnityEngine.UIElements.IStyle.borderRightColor
		{
			get
			{
				return base.GetStyleColor(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderRightColor);
			}
			set
			{
				bool flag = this.SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderRightColor, value, this.ve.sharedStyle.borderRightColor);
				if (flag)
				{
					this.ve.IncrementVersion((VersionChangeType)2080);
				}
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000686 RID: 1670 RVA: 0x0000CA78 File Offset: 0x0000AC78
		// (set) Token: 0x06000687 RID: 1671 RVA: 0x0000CA98 File Offset: 0x0000AC98
		public StyleColor UnityEngine.UIElements.IStyle.borderTopColor
		{
			get
			{
				return base.GetStyleColor(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderTopColor);
			}
			set
			{
				bool flag = this.SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderTopColor, value, this.ve.sharedStyle.borderTopColor);
				if (flag)
				{
					this.ve.IncrementVersion((VersionChangeType)2080);
				}
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000688 RID: 1672 RVA: 0x0000CADC File Offset: 0x0000ACDC
		// (set) Token: 0x06000689 RID: 1673 RVA: 0x0000CAFC File Offset: 0x0000ACFC
		public StyleLength UnityEngine.UIElements.IStyle.borderTopLeftRadius
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderTopLeftRadius);
			}
			set
			{
				bool flag = this.SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderTopLeftRadius, value, this.ve.sharedStyle.borderTopLeftRadius);
				if (flag)
				{
					this.ve.IncrementVersion((VersionChangeType)2208);
				}
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x0600068A RID: 1674 RVA: 0x0000CB40 File Offset: 0x0000AD40
		// (set) Token: 0x0600068B RID: 1675 RVA: 0x0000CB60 File Offset: 0x0000AD60
		public StyleLength UnityEngine.UIElements.IStyle.borderTopRightRadius
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderTopRightRadius);
			}
			set
			{
				bool flag = this.SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderTopRightRadius, value, this.ve.sharedStyle.borderTopRightRadius);
				if (flag)
				{
					this.ve.IncrementVersion((VersionChangeType)2208);
				}
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x0600068C RID: 1676 RVA: 0x0000CBA4 File Offset: 0x0000ADA4
		// (set) Token: 0x0600068D RID: 1677 RVA: 0x000068EF File Offset: 0x00004AEF
		public StyleLength UnityEngine.UIElements.IStyle.bottom
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.Bottom);
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x0600068E RID: 1678 RVA: 0x0000CBC4 File Offset: 0x0000ADC4
		// (set) Token: 0x0600068F RID: 1679 RVA: 0x0000CBE0 File Offset: 0x0000ADE0
		public StyleColor UnityEngine.UIElements.IStyle.color
		{
			get
			{
				return base.GetStyleColor(UnityEngine.UIElements.StyleSheets.StylePropertyId.Color);
			}
			set
			{
				bool flag = this.SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId.Color, value, this.ve.sharedStyle.color);
				if (flag)
				{
					this.ve.IncrementVersion((VersionChangeType)2096);
				}
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000690 RID: 1680 RVA: 0x0000CC20 File Offset: 0x0000AE20
		// (set) Token: 0x06000691 RID: 1681 RVA: 0x000068FC File Offset: 0x00004AFC
		public StyleLength UnityEngine.UIElements.IStyle.flexBasis
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.FlexBasis);
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000692 RID: 1682 RVA: 0x0000CC40 File Offset: 0x0000AE40
		// (set) Token: 0x06000693 RID: 1683 RVA: 0x0000CC5C File Offset: 0x0000AE5C
		public StyleLength UnityEngine.UIElements.IStyle.fontSize
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.FontSize);
			}
			set
			{
				bool flag = this.SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId.FontSize, value, this.ve.sharedStyle.fontSize);
				if (flag)
				{
					this.ve.IncrementVersion((VersionChangeType)56);
				}
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000694 RID: 1684 RVA: 0x0000CC98 File Offset: 0x0000AE98
		// (set) Token: 0x06000695 RID: 1685 RVA: 0x00006909 File Offset: 0x00004B09
		public StyleLength UnityEngine.UIElements.IStyle.height
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.Height);
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000696 RID: 1686 RVA: 0x0000CCB8 File Offset: 0x0000AEB8
		// (set) Token: 0x06000697 RID: 1687 RVA: 0x00006916 File Offset: 0x00004B16
		public StyleLength UnityEngine.UIElements.IStyle.left
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.Left);
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000698 RID: 1688 RVA: 0x0000CCD8 File Offset: 0x0000AED8
		// (set) Token: 0x06000699 RID: 1689 RVA: 0x00006923 File Offset: 0x00004B23
		public StyleLength UnityEngine.UIElements.IStyle.marginBottom
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.MarginBottom);
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x0600069A RID: 1690 RVA: 0x0000CCF8 File Offset: 0x0000AEF8
		// (set) Token: 0x0600069B RID: 1691 RVA: 0x00006930 File Offset: 0x00004B30
		public StyleLength UnityEngine.UIElements.IStyle.marginLeft
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.MarginLeft);
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x0600069C RID: 1692 RVA: 0x0000CD18 File Offset: 0x0000AF18
		// (set) Token: 0x0600069D RID: 1693 RVA: 0x0000693D File Offset: 0x00004B3D
		public StyleLength UnityEngine.UIElements.IStyle.marginRight
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.MarginRight);
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x0600069E RID: 1694 RVA: 0x0000CD38 File Offset: 0x0000AF38
		// (set) Token: 0x0600069F RID: 1695 RVA: 0x0000694A File Offset: 0x00004B4A
		public StyleLength UnityEngine.UIElements.IStyle.marginTop
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.MarginTop);
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060006A0 RID: 1696 RVA: 0x0000CD58 File Offset: 0x0000AF58
		// (set) Token: 0x060006A1 RID: 1697 RVA: 0x00006957 File Offset: 0x00004B57
		public StyleLength UnityEngine.UIElements.IStyle.maxHeight
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.MaxHeight);
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060006A2 RID: 1698 RVA: 0x0000CD78 File Offset: 0x0000AF78
		// (set) Token: 0x060006A3 RID: 1699 RVA: 0x00006964 File Offset: 0x00004B64
		public StyleLength UnityEngine.UIElements.IStyle.maxWidth
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.MaxWidth);
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060006A4 RID: 1700 RVA: 0x0000CD98 File Offset: 0x0000AF98
		// (set) Token: 0x060006A5 RID: 1701 RVA: 0x00006971 File Offset: 0x00004B71
		public StyleLength UnityEngine.UIElements.IStyle.minHeight
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.MinHeight);
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060006A6 RID: 1702 RVA: 0x0000CDB8 File Offset: 0x0000AFB8
		// (set) Token: 0x060006A7 RID: 1703 RVA: 0x0000697E File Offset: 0x00004B7E
		public StyleLength UnityEngine.UIElements.IStyle.minWidth
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.MinWidth);
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060006A8 RID: 1704 RVA: 0x0000CDD8 File Offset: 0x0000AFD8
		// (set) Token: 0x060006A9 RID: 1705 RVA: 0x0000698B File Offset: 0x00004B8B
		public StyleLength UnityEngine.UIElements.IStyle.paddingBottom
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.PaddingBottom);
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060006AA RID: 1706 RVA: 0x0000CDF8 File Offset: 0x0000AFF8
		// (set) Token: 0x060006AB RID: 1707 RVA: 0x00006998 File Offset: 0x00004B98
		public StyleLength UnityEngine.UIElements.IStyle.paddingLeft
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.PaddingLeft);
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060006AC RID: 1708 RVA: 0x0000CE18 File Offset: 0x0000B018
		// (set) Token: 0x060006AD RID: 1709 RVA: 0x000069A5 File Offset: 0x00004BA5
		public StyleLength UnityEngine.UIElements.IStyle.paddingRight
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.PaddingRight);
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060006AE RID: 1710 RVA: 0x0000CE38 File Offset: 0x0000B038
		// (set) Token: 0x060006AF RID: 1711 RVA: 0x000069B2 File Offset: 0x00004BB2
		public StyleLength UnityEngine.UIElements.IStyle.paddingTop
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.PaddingTop);
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x060006B0 RID: 1712 RVA: 0x0000CE58 File Offset: 0x0000B058
		// (set) Token: 0x060006B1 RID: 1713 RVA: 0x000069BF File Offset: 0x00004BBF
		public StyleLength UnityEngine.UIElements.IStyle.right
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.Right);
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060006B2 RID: 1714 RVA: 0x0000CE78 File Offset: 0x0000B078
		// (set) Token: 0x060006B3 RID: 1715 RVA: 0x000069CC File Offset: 0x00004BCC
		public StyleLength UnityEngine.UIElements.IStyle.top
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.Top);
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060006B4 RID: 1716 RVA: 0x0000CE98 File Offset: 0x0000B098
		// (set) Token: 0x060006B5 RID: 1717 RVA: 0x0000CEB8 File Offset: 0x0000B0B8
		public StyleColor UnityEngine.UIElements.IStyle.unityBackgroundImageTintColor
		{
			get
			{
				return base.GetStyleColor(UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityBackgroundImageTintColor);
			}
			set
			{
				bool flag = this.SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityBackgroundImageTintColor, value, this.ve.sharedStyle.unityBackgroundImageTintColor);
				if (flag)
				{
					this.ve.IncrementVersion((VersionChangeType)2080);
				}
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060006B6 RID: 1718 RVA: 0x0000CEFC File Offset: 0x0000B0FC
		// (set) Token: 0x060006B7 RID: 1719 RVA: 0x000069D9 File Offset: 0x00004BD9
		public StyleLength UnityEngine.UIElements.IStyle.width
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.Width);
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}
