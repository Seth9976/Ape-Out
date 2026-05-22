using System;
using System.Runtime.InteropServices;
using UnityEngine.UIElements.StyleSheets;
using UnityEngine.Yoga;

namespace UnityEngine.UIElements
{
	// Token: 0x02000113 RID: 275
	public class ComputedStyle
	{
		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000636 RID: 1590 RVA: 0x000065E3 File Offset: 0x000047E3
		public int customPropertiesCount
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x0000C6A0 File Offset: 0x0000A8A0
		public static ComputedStyle Create([Optional] bool isShared)
		{
			ComputedStyle computedStyle = new ComputedStyle(isShared);
			computedStyle.CopyFrom(UnityEngine.UIElements.StyleSheets.InitialStyle.Get());
			return computedStyle;
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x000065F0 File Offset: 0x000047F0
		public static ComputedStyle Create(ComputedStyle parentStyle, [Optional] bool isShared)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x0000C6C8 File Offset: 0x0000A8C8
		public static ComputedStyle CreateUninitialized([Optional] bool isShared)
		{
			return new ComputedStyle(isShared);
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x000065FD File Offset: 0x000047FD
		public void CopyShared(ComputedStyle sharedStyle)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x0000660A File Offset: 0x0000480A
		public void FinalizeApply(ComputedStyle parentStyle)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x00006617 File Offset: 0x00004817
		public void SyncWithLayout(YogaNode targetNode)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x00006624 File Offset: 0x00004824
		public bool ApplyGlobalKeyword(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, ComputedStyle parentStyle)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00006631 File Offset: 0x00004831
		public void RemoveCustomStyleProperty(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x0000663E File Offset: 0x0000483E
		public void ApplyCustomStyleProperty(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000640 RID: 1600 RVA: 0x0000664B File Offset: 0x0000484B
		public StyleColor backgroundColor
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000641 RID: 1601 RVA: 0x00006658 File Offset: 0x00004858
		public StyleBackground backgroundImage
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000642 RID: 1602 RVA: 0x00006665 File Offset: 0x00004865
		public StyleColor borderBottomColor
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000643 RID: 1603 RVA: 0x00006672 File Offset: 0x00004872
		public StyleLength borderBottomLeftRadius
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000644 RID: 1604 RVA: 0x0000667F File Offset: 0x0000487F
		public StyleLength borderBottomRightRadius
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000645 RID: 1605 RVA: 0x0000668C File Offset: 0x0000488C
		public StyleColor borderLeftColor
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000646 RID: 1606 RVA: 0x00006699 File Offset: 0x00004899
		public StyleColor borderRightColor
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000647 RID: 1607 RVA: 0x000066A6 File Offset: 0x000048A6
		public StyleColor borderTopColor
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000648 RID: 1608 RVA: 0x000066B3 File Offset: 0x000048B3
		public StyleLength borderTopLeftRadius
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000649 RID: 1609 RVA: 0x000066C0 File Offset: 0x000048C0
		public StyleLength borderTopRightRadius
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600064A RID: 1610 RVA: 0x000066CD File Offset: 0x000048CD
		public StyleLength bottom
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x0600064B RID: 1611 RVA: 0x000066DA File Offset: 0x000048DA
		public StyleColor color
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x0600064C RID: 1612 RVA: 0x000066E7 File Offset: 0x000048E7
		public StyleCursor cursor
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x0600064D RID: 1613 RVA: 0x000066F4 File Offset: 0x000048F4
		public StyleLength flexBasis
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x0600064E RID: 1614 RVA: 0x00006701 File Offset: 0x00004901
		public StyleLength fontSize
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x0600064F RID: 1615 RVA: 0x0000670E File Offset: 0x0000490E
		public StyleLength height
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000650 RID: 1616 RVA: 0x0000671B File Offset: 0x0000491B
		public StyleLength left
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x00006728 File Offset: 0x00004928
		public StyleLength marginBottom
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000652 RID: 1618 RVA: 0x00006735 File Offset: 0x00004935
		public StyleLength marginLeft
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000653 RID: 1619 RVA: 0x00006742 File Offset: 0x00004942
		public StyleLength marginRight
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000654 RID: 1620 RVA: 0x0000674F File Offset: 0x0000494F
		public StyleLength marginTop
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000655 RID: 1621 RVA: 0x0000675C File Offset: 0x0000495C
		public StyleLength maxHeight
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000656 RID: 1622 RVA: 0x00006769 File Offset: 0x00004969
		public StyleLength maxWidth
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000657 RID: 1623 RVA: 0x00006776 File Offset: 0x00004976
		public StyleLength minHeight
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000658 RID: 1624 RVA: 0x00006783 File Offset: 0x00004983
		public StyleLength minWidth
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000659 RID: 1625 RVA: 0x00006790 File Offset: 0x00004990
		public StyleLength paddingBottom
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x0600065A RID: 1626 RVA: 0x0000679D File Offset: 0x0000499D
		public StyleLength paddingLeft
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x0600065B RID: 1627 RVA: 0x000067AA File Offset: 0x000049AA
		public StyleLength paddingRight
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x0600065C RID: 1628 RVA: 0x000067B7 File Offset: 0x000049B7
		public StyleLength paddingTop
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x0600065D RID: 1629 RVA: 0x000067C4 File Offset: 0x000049C4
		public StyleLength right
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x0600065E RID: 1630 RVA: 0x000067D1 File Offset: 0x000049D1
		public StyleLength top
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x0600065F RID: 1631 RVA: 0x000067DE File Offset: 0x000049DE
		public StyleColor unityBackgroundImageTintColor
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000660 RID: 1632 RVA: 0x000067EB File Offset: 0x000049EB
		public StyleLength width
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x000067F8 File Offset: 0x000049F8
		public void CopyFrom(ComputedStyle other)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x00006805 File Offset: 0x00004A05
		public void ApplyProperties(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, ComputedStyle parentStyle)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x00006812 File Offset: 0x00004A12
		public void ApplyStyleCursor(StyleCursor sc)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x0000C6E0 File Offset: 0x0000A8E0
		public void ApplyInitialValue(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader)
		{
			UnityEngine.UIElements.StyleSheets.StylePropertyId propertyId = reader.propertyId;
			UnityEngine.UIElements.StyleSheets.StylePropertyId stylePropertyId = propertyId;
			if (stylePropertyId != UnityEngine.UIElements.StyleSheets.StylePropertyId.Custom)
			{
				this.ApplyInitialValue(reader.propertyId);
			}
			else
			{
				this.RemoveCustomStyleProperty(reader);
			}
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x0000681F File Offset: 0x00004A1F
		public void ApplyInitialValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x0000C718 File Offset: 0x0000A918
		public void ApplyUnsetValue(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, ComputedStyle parentStyle)
		{
			UnityEngine.UIElements.StyleSheets.StylePropertyId propertyId = reader.propertyId;
			UnityEngine.UIElements.StyleSheets.StylePropertyId stylePropertyId = propertyId;
			if (stylePropertyId != UnityEngine.UIElements.StyleSheets.StylePropertyId.Custom)
			{
				this.ApplyUnsetValue(reader.propertyId, parentStyle);
			}
			else
			{
				this.RemoveCustomStyleProperty(reader);
			}
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x0000682C File Offset: 0x00004A2C
		public void ApplyUnsetValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, ComputedStyle parentStyle)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
