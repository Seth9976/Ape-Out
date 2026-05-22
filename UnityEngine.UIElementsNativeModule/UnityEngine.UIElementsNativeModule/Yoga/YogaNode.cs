using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Yoga
{
	// Token: 0x02000006 RID: 6
	public class YogaNode : Object
	{
		// Token: 0x06000076 RID: 118 RVA: 0x000037A8 File Offset: 0x000019A8
		// Note: this type is marked as 'beforefieldinit'.
		static YogaNode()
		{
			Il2CppClassPointerStore<YogaNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsNativeModule.dll", "UnityEngine.Yoga", "YogaNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YogaNode>.NativeClassPtr);
			YogaNode.NativeFieldInfoPtr__ygNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, "_ygNode");
			YogaNode.NativeFieldInfoPtr__measureFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, "_measureFunction");
			YogaNode.NativeFieldInfoPtr__baselineFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, "_baselineFunction");
			YogaNode.NativeMethodInfoPtr_MeasureInternal_Public_Static_YogaSize_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663307);
			YogaNode.NativeMethodInfoPtr_BaselineInternal_Public_Static_Single_YogaNode_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663308);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000383C File Offset: 0x00001A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533443, XrefRangeEnd = 533444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static YogaSize MeasureInternal(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref widthMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref heightMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_MeasureInternal_Public_Static_YogaSize_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000038B8 File Offset: 0x00001AB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533444, XrefRangeEnd = 533445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float BaselineInternal(YogaNode node, float width, float height)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_BaselineInternal_Public_Static_Single_YogaNode_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000025B0 File Offset: 0x000007B0
		public YogaNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00003918 File Offset: 0x00001B18
		// (set) Token: 0x0600007B RID: 123 RVA: 0x000025B9 File Offset: 0x000007B9
		public unsafe IntPtr _ygNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YogaNode.NativeFieldInfoPtr__ygNode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YogaNode.NativeFieldInfoPtr__ygNode)) = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00003940 File Offset: 0x00001B40
		// (set) Token: 0x0600007D RID: 125 RVA: 0x000025D4 File Offset: 0x000007D4
		public unsafe MeasureFunction _measureFunction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YogaNode.NativeFieldInfoPtr__measureFunction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeasureFunction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YogaNode.NativeFieldInfoPtr__measureFunction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00003970 File Offset: 0x00001B70
		// (set) Token: 0x0600007F RID: 127 RVA: 0x000025F3 File Offset: 0x000007F3
		public unsafe BaselineFunction _baselineFunction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YogaNode.NativeFieldInfoPtr__baselineFunction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaselineFunction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YogaNode.NativeFieldInfoPtr__baselineFunction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000080 RID: 128 RVA: 0x000039A0 File Offset: 0x00001BA0
		// (set) Token: 0x06000081 RID: 129 RVA: 0x00002612 File Offset: 0x00000812
		public float BorderLeftWidth
		{
			get
			{
				return Native.YGNodeStyleGetBorder(this._ygNode, YogaEdge.Left);
			}
			set
			{
				Native.YGNodeStyleSetBorder(this._ygNode, YogaEdge.Left, value);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000082 RID: 130 RVA: 0x000039C0 File Offset: 0x00001BC0
		// (set) Token: 0x06000083 RID: 131 RVA: 0x00002623 File Offset: 0x00000823
		public float BorderTopWidth
		{
			get
			{
				return Native.YGNodeStyleGetBorder(this._ygNode, YogaEdge.Top);
			}
			set
			{
				Native.YGNodeStyleSetBorder(this._ygNode, YogaEdge.Top, value);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000084 RID: 132 RVA: 0x000039E0 File Offset: 0x00001BE0
		// (set) Token: 0x06000085 RID: 133 RVA: 0x00002634 File Offset: 0x00000834
		public float BorderRightWidth
		{
			get
			{
				return Native.YGNodeStyleGetBorder(this._ygNode, YogaEdge.Right);
			}
			set
			{
				Native.YGNodeStyleSetBorder(this._ygNode, YogaEdge.Right, value);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00003A00 File Offset: 0x00001C00
		// (set) Token: 0x06000087 RID: 135 RVA: 0x00002645 File Offset: 0x00000845
		public float BorderBottomWidth
		{
			get
			{
				return Native.YGNodeStyleGetBorder(this._ygNode, YogaEdge.Bottom);
			}
			set
			{
				Native.YGNodeStyleSetBorder(this._ygNode, YogaEdge.Bottom, value);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00003A20 File Offset: 0x00001C20
		// (set) Token: 0x06000089 RID: 137 RVA: 0x00002656 File Offset: 0x00000856
		public float BorderStartWidth
		{
			get
			{
				return Native.YGNodeStyleGetBorder(this._ygNode, YogaEdge.Start);
			}
			set
			{
				Native.YGNodeStyleSetBorder(this._ygNode, YogaEdge.Start, value);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00003A40 File Offset: 0x00001C40
		// (set) Token: 0x0600008B RID: 139 RVA: 0x00002667 File Offset: 0x00000867
		public float BorderEndWidth
		{
			get
			{
				return Native.YGNodeStyleGetBorder(this._ygNode, YogaEdge.End);
			}
			set
			{
				Native.YGNodeStyleSetBorder(this._ygNode, YogaEdge.End, value);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00003A60 File Offset: 0x00001C60
		// (set) Token: 0x0600008D RID: 141 RVA: 0x00002678 File Offset: 0x00000878
		public float BorderWidth
		{
			get
			{
				return Native.YGNodeStyleGetBorder(this._ygNode, YogaEdge.All);
			}
			set
			{
				Native.YGNodeStyleSetBorder(this._ygNode, YogaEdge.All, value);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00003A80 File Offset: 0x00001C80
		public float LayoutMarginLeft
		{
			get
			{
				return Native.YGNodeLayoutGetMargin(this._ygNode, YogaEdge.Left);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00003AA0 File Offset: 0x00001CA0
		public float LayoutMarginTop
		{
			get
			{
				return Native.YGNodeLayoutGetMargin(this._ygNode, YogaEdge.Top);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00003AC0 File Offset: 0x00001CC0
		public float LayoutMarginRight
		{
			get
			{
				return Native.YGNodeLayoutGetMargin(this._ygNode, YogaEdge.Right);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00003AE0 File Offset: 0x00001CE0
		public float LayoutMarginBottom
		{
			get
			{
				return Native.YGNodeLayoutGetMargin(this._ygNode, YogaEdge.Bottom);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00003B00 File Offset: 0x00001D00
		public float LayoutMarginStart
		{
			get
			{
				return Native.YGNodeLayoutGetMargin(this._ygNode, YogaEdge.Start);
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00003B20 File Offset: 0x00001D20
		public float LayoutMarginEnd
		{
			get
			{
				return Native.YGNodeLayoutGetMargin(this._ygNode, YogaEdge.End);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00003B40 File Offset: 0x00001D40
		public float LayoutPaddingLeft
		{
			get
			{
				return Native.YGNodeLayoutGetPadding(this._ygNode, YogaEdge.Left);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00003B60 File Offset: 0x00001D60
		public float LayoutPaddingTop
		{
			get
			{
				return Native.YGNodeLayoutGetPadding(this._ygNode, YogaEdge.Top);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00003B80 File Offset: 0x00001D80
		public float LayoutPaddingRight
		{
			get
			{
				return Native.YGNodeLayoutGetPadding(this._ygNode, YogaEdge.Right);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00003BA0 File Offset: 0x00001DA0
		public float LayoutPaddingBottom
		{
			get
			{
				return Native.YGNodeLayoutGetPadding(this._ygNode, YogaEdge.Bottom);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00003BC0 File Offset: 0x00001DC0
		public float LayoutPaddingStart
		{
			get
			{
				return Native.YGNodeLayoutGetPadding(this._ygNode, YogaEdge.Start);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00003BE0 File Offset: 0x00001DE0
		public float LayoutPaddingEnd
		{
			get
			{
				return Native.YGNodeLayoutGetPadding(this._ygNode, YogaEdge.End);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00003C00 File Offset: 0x00001E00
		public float ComputedFlexBasis
		{
			get
			{
				return Native.YGNodeGetComputedFlexBasis(this._ygNode);
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00003C20 File Offset: 0x00001E20
		public ~YogaNode()
		{
			Native.YGNodeFree(this._ygNode);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002689 File Offset: 0x00000889
		public void Reset()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00002696 File Offset: 0x00000896
		// (set) Token: 0x0600009E RID: 158 RVA: 0x000026A3 File Offset: 0x000008A3
		public YogaConfig Config
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

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00003C58 File Offset: 0x00001E58
		public bool IsDirty
		{
			get
			{
				return Native.YGNodeIsDirty(this._ygNode);
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000026B0 File Offset: 0x000008B0
		public virtual void MarkDirty()
		{
			Native.YGNodeMarkDirty(this._ygNode);
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00003C78 File Offset: 0x00001E78
		public bool HasNewLayout
		{
			get
			{
				return Native.YGNodeGetHasNewLayout(this._ygNode);
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x000026BF File Offset: 0x000008BF
		public void MarkHasNewLayout()
		{
			Native.YGNodeSetHasNewLayout(this._ygNode, true);
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x000026CF File Offset: 0x000008CF
		public YogaNode Parent
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00003C98 File Offset: 0x00001E98
		public bool IsMeasureDefined
		{
			get
			{
				return this._measureFunction != null;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00003CB4 File Offset: 0x00001EB4
		public bool IsBaselineDefined
		{
			get
			{
				return this._baselineFunction != null;
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000026DC File Offset: 0x000008DC
		public void CopyStyle(YogaNode srcNode)
		{
			Native.YGNodeCopyStyle(this._ygNode, srcNode._ygNode);
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x00003CD0 File Offset: 0x00001ED0
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x000026F1 File Offset: 0x000008F1
		public YogaDirection StyleDirection
		{
			get
			{
				return Native.YGNodeStyleGetDirection(this._ygNode);
			}
			set
			{
				Native.YGNodeStyleSetDirection(this._ygNode, value);
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00003CF0 File Offset: 0x00001EF0
		// (set) Token: 0x060000AA RID: 170 RVA: 0x00002701 File Offset: 0x00000901
		public YogaFlexDirection FlexDirection
		{
			get
			{
				return Native.YGNodeStyleGetFlexDirection(this._ygNode);
			}
			set
			{
				Native.YGNodeStyleSetFlexDirection(this._ygNode, value);
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000AB RID: 171 RVA: 0x00003D10 File Offset: 0x00001F10
		// (set) Token: 0x060000AC RID: 172 RVA: 0x00002711 File Offset: 0x00000911
		public YogaJustify JustifyContent
		{
			get
			{
				return Native.YGNodeStyleGetJustifyContent(this._ygNode);
			}
			set
			{
				Native.YGNodeStyleSetJustifyContent(this._ygNode, value);
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00003D30 File Offset: 0x00001F30
		// (set) Token: 0x060000AE RID: 174 RVA: 0x00002721 File Offset: 0x00000921
		public YogaDisplay Display
		{
			get
			{
				return Native.YGNodeStyleGetDisplay(this._ygNode);
			}
			set
			{
				Native.YGNodeStyleSetDisplay(this._ygNode, value);
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00003D50 File Offset: 0x00001F50
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x00002731 File Offset: 0x00000931
		public YogaAlign AlignItems
		{
			get
			{
				return Native.YGNodeStyleGetAlignItems(this._ygNode);
			}
			set
			{
				Native.YGNodeStyleSetAlignItems(this._ygNode, value);
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x00003D70 File Offset: 0x00001F70
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x00002741 File Offset: 0x00000941
		public YogaAlign AlignSelf
		{
			get
			{
				return Native.YGNodeStyleGetAlignSelf(this._ygNode);
			}
			set
			{
				Native.YGNodeStyleSetAlignSelf(this._ygNode, value);
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00003D90 File Offset: 0x00001F90
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x00002751 File Offset: 0x00000951
		public YogaAlign AlignContent
		{
			get
			{
				return Native.YGNodeStyleGetAlignContent(this._ygNode);
			}
			set
			{
				Native.YGNodeStyleSetAlignContent(this._ygNode, value);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00003DB0 File Offset: 0x00001FB0
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x00002761 File Offset: 0x00000961
		public YogaPositionType PositionType
		{
			get
			{
				return Native.YGNodeStyleGetPositionType(this._ygNode);
			}
			set
			{
				Native.YGNodeStyleSetPositionType(this._ygNode, value);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00003DD0 File Offset: 0x00001FD0
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x00002771 File Offset: 0x00000971
		public YogaWrap Wrap
		{
			get
			{
				return Native.YGNodeStyleGetFlexWrap(this._ygNode);
			}
			set
			{
				Native.YGNodeStyleSetFlexWrap(this._ygNode, value);
			}
		}

		// Token: 0x17000027 RID: 39
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x00002781 File Offset: 0x00000981
		public float Flex
		{
			set
			{
				Native.YGNodeStyleSetFlex(this._ygNode, value);
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00003DF0 File Offset: 0x00001FF0
		// (set) Token: 0x060000BB RID: 187 RVA: 0x00002791 File Offset: 0x00000991
		public float FlexGrow
		{
			get
			{
				return Native.YGNodeStyleGetFlexGrow(this._ygNode);
			}
			set
			{
				Native.YGNodeStyleSetFlexGrow(this._ygNode, value);
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000BC RID: 188 RVA: 0x00003E10 File Offset: 0x00002010
		// (set) Token: 0x060000BD RID: 189 RVA: 0x000027A1 File Offset: 0x000009A1
		public float FlexShrink
		{
			get
			{
				return Native.YGNodeStyleGetFlexShrink(this._ygNode);
			}
			set
			{
				Native.YGNodeStyleSetFlexShrink(this._ygNode, value);
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000BE RID: 190 RVA: 0x00003E30 File Offset: 0x00002030
		// (set) Token: 0x060000BF RID: 191 RVA: 0x000027B1 File Offset: 0x000009B1
		public float AspectRatio
		{
			get
			{
				return Native.YGNodeStyleGetAspectRatio(this._ygNode);
			}
			set
			{
				Native.YGNodeStyleSetAspectRatio(this._ygNode, value);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00003E50 File Offset: 0x00002050
		public float LayoutX
		{
			get
			{
				return Native.YGNodeLayoutGetLeft(this._ygNode);
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00003E70 File Offset: 0x00002070
		public float LayoutY
		{
			get
			{
				return Native.YGNodeLayoutGetTop(this._ygNode);
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00003E90 File Offset: 0x00002090
		public float LayoutRight
		{
			get
			{
				return Native.YGNodeLayoutGetRight(this._ygNode);
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00003EB0 File Offset: 0x000020B0
		public float LayoutBottom
		{
			get
			{
				return Native.YGNodeLayoutGetBottom(this._ygNode);
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00003ED0 File Offset: 0x000020D0
		public float LayoutWidth
		{
			get
			{
				return Native.YGNodeLayoutGetWidth(this._ygNode);
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x00003EF0 File Offset: 0x000020F0
		public float LayoutHeight
		{
			get
			{
				return Native.YGNodeLayoutGetHeight(this._ygNode);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x00003F10 File Offset: 0x00002110
		public YogaDirection LayoutDirection
		{
			get
			{
				return Native.YGNodeLayoutGetDirection(this._ygNode);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x00003F30 File Offset: 0x00002130
		// (set) Token: 0x060000C8 RID: 200 RVA: 0x000027C1 File Offset: 0x000009C1
		public YogaOverflow Overflow
		{
			get
			{
				return Native.YGNodeStyleGetOverflow(this._ygNode);
			}
			set
			{
				Native.YGNodeStyleSetOverflow(this._ygNode, value);
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x000027D1 File Offset: 0x000009D1
		// (set) Token: 0x060000CA RID: 202 RVA: 0x000027DE File Offset: 0x000009DE
		public Object Data
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

		// Token: 0x17000034 RID: 52
		public YogaNode this[int index]
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000CC RID: 204 RVA: 0x000027F8 File Offset: 0x000009F8
		public int Count
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002805 File Offset: 0x00000A05
		public void MarkLayoutSeen()
		{
			Native.YGNodeSetHasNewLayout(this._ygNode, false);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00003F50 File Offset: 0x00002150
		public bool ValuesEqual(float f1, float f2)
		{
			bool flag = Single.IsNaN(f1) || Single.IsNaN(f2);
			bool flag2;
			if (flag)
			{
				flag2 = Single.IsNaN(f1) && Single.IsNaN(f2);
			}
			else
			{
				flag2 = Math.Abs(f2 - f1) < float.Epsilon;
			}
			return flag2;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002815 File Offset: 0x00000A15
		public void Insert(int index, YogaNode node)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002822 File Offset: 0x00000A22
		public void RemoveAt(int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000282F File Offset: 0x00000A2F
		public void AddChild(YogaNode child)
		{
			this.Insert(this.Count, child);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00003F9C File Offset: 0x0000219C
		public void RemoveChild(YogaNode child)
		{
			int num = this.IndexOf(child);
			bool flag = num >= 0;
			if (flag)
			{
				this.RemoveAt(num);
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002840 File Offset: 0x00000A40
		public void Clear()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000284D File Offset: 0x00000A4D
		public int IndexOf(YogaNode node)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00003FC8 File Offset: 0x000021C8
		public void SetMeasureFunction(MeasureFunction measureFunction)
		{
			this._measureFunction = measureFunction;
			bool flag = measureFunction == null;
			if (flag)
			{
				bool flag2 = !this.IsBaselineDefined;
				if (flag2)
				{
					Native.YGSetManagedObject(this._ygNode, null);
				}
				Native.YGNodeRemoveMeasureFunc(this._ygNode);
			}
			else
			{
				Native.YGSetManagedObject(this._ygNode, this);
				Native.YGNodeSetMeasureFunc(this._ygNode);
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000402C File Offset: 0x0000222C
		public void SetBaselineFunction(BaselineFunction baselineFunction)
		{
			this._baselineFunction = baselineFunction;
			bool flag = baselineFunction == null;
			if (flag)
			{
				bool flag2 = !this.IsMeasureDefined;
				if (flag2)
				{
					Native.YGSetManagedObject(this._ygNode, null);
				}
				Native.YGNodeRemoveBaselineFunc(this._ygNode);
			}
			else
			{
				Native.YGSetManagedObject(this._ygNode, this);
				Native.YGNodeSetBaselineFunc(this._ygNode);
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000285A File Offset: 0x00000A5A
		public void CalculateLayout([Optional] float width, [Optional] float height)
		{
			Native.YGNodeCalculateLayout(this._ygNode, width, height, Native.YGNodeStyleGetDirection(this._ygNode));
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002876 File Offset: 0x00000A76
		public string Print([Optional] YogaPrintOptions options)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002883 File Offset: 0x00000A83
		public IEnumerator<YogaNode> GetEnumerator()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002890 File Offset: 0x00000A90
		public IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00004090 File Offset: 0x00002290
		public static int GetInstanceCount()
		{
			return Native.YGNodeGetInstanceCount();
		}

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeFieldInfoPtr__ygNode;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeFieldInfoPtr__measureFunction;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeFieldInfoPtr__baselineFunction;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_MeasureInternal_Public_Static_YogaSize_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_BaselineInternal_Public_Static_Single_YogaNode_Single_Single_0;

		// Token: 0x0200007D RID: 125
		public sealed class <>c__DisplayClass245_0
		{
		}
	}
}
