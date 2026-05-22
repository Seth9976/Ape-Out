using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Yoga
{
	// Token: 0x02000005 RID: 5
	public static class Native : Object
	{
		// Token: 0x06000013 RID: 19 RVA: 0x000030B0 File Offset: 0x000012B0
		// Note: this type is marked as 'beforefieldinit'.
		static Native()
		{
			Il2CppClassPointerStore<Native>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsNativeModule.dll", "UnityEngine.Yoga", "Native");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Native>.NativeClassPtr);
			Native.NativeMethodInfoPtr_YGNodeMeasureInvoke_Public_Static_Void_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663305);
			Native.NativeMethodInfoPtr_YGNodeBaselineInvoke_Public_Static_Void_YogaNode_Single_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663306);
			Native.YGNodeNewDelegateField = IL2CPP.ResolveICall<Native.YGNodeNewDelegate>("UnityEngine.Yoga.Native::YGNodeNew");
			Native.YGNodeNewWithConfigDelegateField = IL2CPP.ResolveICall<Native.YGNodeNewWithConfigDelegate>("UnityEngine.Yoga.Native::YGNodeNewWithConfig");
			Native.YGNodeFreeInternalDelegateField = IL2CPP.ResolveICall<Native.YGNodeFreeInternalDelegate>("UnityEngine.Yoga.Native::YGNodeFreeInternal");
			Native.YGNodeResetDelegateField = IL2CPP.ResolveICall<Native.YGNodeResetDelegate>("UnityEngine.Yoga.Native::YGNodeReset");
			Native.YGSetManagedObjectDelegateField = IL2CPP.ResolveICall<Native.YGSetManagedObjectDelegate>("UnityEngine.Yoga.Native::YGSetManagedObject");
			Native.YGNodeSetConfigDelegateField = IL2CPP.ResolveICall<Native.YGNodeSetConfigDelegate>("UnityEngine.Yoga.Native::YGNodeSetConfig");
			Native.YGConfigGetDefaultDelegateField = IL2CPP.ResolveICall<Native.YGConfigGetDefaultDelegate>("UnityEngine.Yoga.Native::YGConfigGetDefault");
			Native.YGConfigNewDelegateField = IL2CPP.ResolveICall<Native.YGConfigNewDelegate>("UnityEngine.Yoga.Native::YGConfigNew");
			Native.YGConfigFreeInternalDelegateField = IL2CPP.ResolveICall<Native.YGConfigFreeInternalDelegate>("UnityEngine.Yoga.Native::YGConfigFreeInternal");
			Native.YGNodeGetInstanceCountDelegateField = IL2CPP.ResolveICall<Native.YGNodeGetInstanceCountDelegate>("UnityEngine.Yoga.Native::YGNodeGetInstanceCount");
			Native.YGConfigGetInstanceCountDelegateField = IL2CPP.ResolveICall<Native.YGConfigGetInstanceCountDelegate>("UnityEngine.Yoga.Native::YGConfigGetInstanceCount");
			Native.YGConfigSetExperimentalFeatureEnabledDelegateField = IL2CPP.ResolveICall<Native.YGConfigSetExperimentalFeatureEnabledDelegate>("UnityEngine.Yoga.Native::YGConfigSetExperimentalFeatureEnabled");
			Native.YGConfigIsExperimentalFeatureEnabledDelegateField = IL2CPP.ResolveICall<Native.YGConfigIsExperimentalFeatureEnabledDelegate>("UnityEngine.Yoga.Native::YGConfigIsExperimentalFeatureEnabled");
			Native.YGConfigSetUseWebDefaultsDelegateField = IL2CPP.ResolveICall<Native.YGConfigSetUseWebDefaultsDelegate>("UnityEngine.Yoga.Native::YGConfigSetUseWebDefaults");
			Native.YGConfigGetUseWebDefaultsDelegateField = IL2CPP.ResolveICall<Native.YGConfigGetUseWebDefaultsDelegate>("UnityEngine.Yoga.Native::YGConfigGetUseWebDefaults");
			Native.YGConfigSetPointScaleFactorDelegateField = IL2CPP.ResolveICall<Native.YGConfigSetPointScaleFactorDelegate>("UnityEngine.Yoga.Native::YGConfigSetPointScaleFactor");
			Native.YGConfigGetPointScaleFactorDelegateField = IL2CPP.ResolveICall<Native.YGConfigGetPointScaleFactorDelegate>("UnityEngine.Yoga.Native::YGConfigGetPointScaleFactor");
			Native.YGNodeInsertChildDelegateField = IL2CPP.ResolveICall<Native.YGNodeInsertChildDelegate>("UnityEngine.Yoga.Native::YGNodeInsertChild");
			Native.YGNodeRemoveChildDelegateField = IL2CPP.ResolveICall<Native.YGNodeRemoveChildDelegate>("UnityEngine.Yoga.Native::YGNodeRemoveChild");
			Native.YGNodeCalculateLayoutDelegateField = IL2CPP.ResolveICall<Native.YGNodeCalculateLayoutDelegate>("UnityEngine.Yoga.Native::YGNodeCalculateLayout");
			Native.YGNodeMarkDirtyDelegateField = IL2CPP.ResolveICall<Native.YGNodeMarkDirtyDelegate>("UnityEngine.Yoga.Native::YGNodeMarkDirty");
			Native.YGNodeIsDirtyDelegateField = IL2CPP.ResolveICall<Native.YGNodeIsDirtyDelegate>("UnityEngine.Yoga.Native::YGNodeIsDirty");
			Native.YGNodePrintDelegateField = IL2CPP.ResolveICall<Native.YGNodePrintDelegate>("UnityEngine.Yoga.Native::YGNodePrint");
			Native.YGNodeCopyStyleDelegateField = IL2CPP.ResolveICall<Native.YGNodeCopyStyleDelegate>("UnityEngine.Yoga.Native::YGNodeCopyStyle");
			Native.YGNodeSetMeasureFuncDelegateField = IL2CPP.ResolveICall<Native.YGNodeSetMeasureFuncDelegate>("UnityEngine.Yoga.Native::YGNodeSetMeasureFunc");
			Native.YGNodeRemoveMeasureFuncDelegateField = IL2CPP.ResolveICall<Native.YGNodeRemoveMeasureFuncDelegate>("UnityEngine.Yoga.Native::YGNodeRemoveMeasureFunc");
			Native.YGNodeSetBaselineFuncDelegateField = IL2CPP.ResolveICall<Native.YGNodeSetBaselineFuncDelegate>("UnityEngine.Yoga.Native::YGNodeSetBaselineFunc");
			Native.YGNodeRemoveBaselineFuncDelegateField = IL2CPP.ResolveICall<Native.YGNodeRemoveBaselineFuncDelegate>("UnityEngine.Yoga.Native::YGNodeRemoveBaselineFunc");
			Native.YGNodeSetHasNewLayoutDelegateField = IL2CPP.ResolveICall<Native.YGNodeSetHasNewLayoutDelegate>("UnityEngine.Yoga.Native::YGNodeSetHasNewLayout");
			Native.YGNodeGetHasNewLayoutDelegateField = IL2CPP.ResolveICall<Native.YGNodeGetHasNewLayoutDelegate>("UnityEngine.Yoga.Native::YGNodeGetHasNewLayout");
			Native.YGNodeStyleSetDirectionDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetDirectionDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetDirection");
			Native.YGNodeStyleGetDirectionDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetDirectionDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetDirection");
			Native.YGNodeStyleSetFlexDirectionDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetFlexDirectionDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetFlexDirection");
			Native.YGNodeStyleGetFlexDirectionDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetFlexDirectionDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetFlexDirection");
			Native.YGNodeStyleSetJustifyContentDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetJustifyContentDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetJustifyContent");
			Native.YGNodeStyleGetJustifyContentDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetJustifyContentDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetJustifyContent");
			Native.YGNodeStyleSetAlignContentDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetAlignContentDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetAlignContent");
			Native.YGNodeStyleGetAlignContentDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetAlignContentDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetAlignContent");
			Native.YGNodeStyleSetAlignItemsDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetAlignItemsDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetAlignItems");
			Native.YGNodeStyleGetAlignItemsDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetAlignItemsDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetAlignItems");
			Native.YGNodeStyleSetAlignSelfDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetAlignSelfDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetAlignSelf");
			Native.YGNodeStyleGetAlignSelfDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetAlignSelfDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetAlignSelf");
			Native.YGNodeStyleSetPositionTypeDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetPositionTypeDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetPositionType");
			Native.YGNodeStyleGetPositionTypeDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetPositionTypeDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetPositionType");
			Native.YGNodeStyleSetFlexWrapDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetFlexWrapDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetFlexWrap");
			Native.YGNodeStyleGetFlexWrapDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetFlexWrapDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetFlexWrap");
			Native.YGNodeStyleSetOverflowDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetOverflowDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetOverflow");
			Native.YGNodeStyleGetOverflowDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetOverflowDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetOverflow");
			Native.YGNodeStyleSetDisplayDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetDisplayDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetDisplay");
			Native.YGNodeStyleGetDisplayDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetDisplayDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetDisplay");
			Native.YGNodeStyleSetFlexDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetFlexDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetFlex");
			Native.YGNodeStyleSetFlexGrowDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetFlexGrowDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetFlexGrow");
			Native.YGNodeStyleGetFlexGrowDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetFlexGrowDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetFlexGrow");
			Native.YGNodeStyleSetFlexShrinkDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetFlexShrinkDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetFlexShrink");
			Native.YGNodeStyleGetFlexShrinkDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetFlexShrinkDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetFlexShrink");
			Native.YGNodeStyleSetFlexBasisDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetFlexBasisDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetFlexBasis");
			Native.YGNodeStyleSetFlexBasisPercentDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetFlexBasisPercentDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetFlexBasisPercent");
			Native.YGNodeStyleSetFlexBasisAutoDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetFlexBasisAutoDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetFlexBasisAuto");
			Native.YGNodeGetComputedFlexBasisDelegateField = IL2CPP.ResolveICall<Native.YGNodeGetComputedFlexBasisDelegate>("UnityEngine.Yoga.Native::YGNodeGetComputedFlexBasis");
			Native.YGNodeStyleSetWidthDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetWidthDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetWidth");
			Native.YGNodeStyleSetWidthPercentDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetWidthPercentDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetWidthPercent");
			Native.YGNodeStyleSetWidthAutoDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetWidthAutoDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetWidthAuto");
			Native.YGNodeStyleSetHeightDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetHeightDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetHeight");
			Native.YGNodeStyleSetHeightPercentDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetHeightPercentDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetHeightPercent");
			Native.YGNodeStyleSetHeightAutoDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetHeightAutoDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetHeightAuto");
			Native.YGNodeStyleSetMinWidthDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetMinWidthDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetMinWidth");
			Native.YGNodeStyleSetMinWidthPercentDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetMinWidthPercentDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetMinWidthPercent");
			Native.YGNodeStyleSetMinHeightDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetMinHeightDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetMinHeight");
			Native.YGNodeStyleSetMinHeightPercentDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetMinHeightPercentDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetMinHeightPercent");
			Native.YGNodeStyleSetMaxWidthDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetMaxWidthDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetMaxWidth");
			Native.YGNodeStyleSetMaxWidthPercentDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetMaxWidthPercentDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetMaxWidthPercent");
			Native.YGNodeStyleSetMaxHeightDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetMaxHeightDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetMaxHeight");
			Native.YGNodeStyleSetMaxHeightPercentDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetMaxHeightPercentDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetMaxHeightPercent");
			Native.YGNodeStyleSetAspectRatioDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetAspectRatioDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetAspectRatio");
			Native.YGNodeStyleGetAspectRatioDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetAspectRatioDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetAspectRatio");
			Native.YGNodeStyleSetPositionDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetPositionDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetPosition");
			Native.YGNodeStyleSetPositionPercentDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetPositionPercentDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetPositionPercent");
			Native.YGNodeStyleSetMarginDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetMarginDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetMargin");
			Native.YGNodeStyleSetMarginPercentDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetMarginPercentDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetMarginPercent");
			Native.YGNodeStyleSetMarginAutoDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetMarginAutoDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetMarginAuto");
			Native.YGNodeStyleSetPaddingDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetPaddingDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetPadding");
			Native.YGNodeStyleSetPaddingPercentDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetPaddingPercentDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetPaddingPercent");
			Native.YGNodeStyleSetBorderDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetBorderDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetBorder");
			Native.YGNodeStyleGetBorderDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetBorderDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetBorder");
			Native.YGNodeLayoutGetLeftDelegateField = IL2CPP.ResolveICall<Native.YGNodeLayoutGetLeftDelegate>("UnityEngine.Yoga.Native::YGNodeLayoutGetLeft");
			Native.YGNodeLayoutGetTopDelegateField = IL2CPP.ResolveICall<Native.YGNodeLayoutGetTopDelegate>("UnityEngine.Yoga.Native::YGNodeLayoutGetTop");
			Native.YGNodeLayoutGetRightDelegateField = IL2CPP.ResolveICall<Native.YGNodeLayoutGetRightDelegate>("UnityEngine.Yoga.Native::YGNodeLayoutGetRight");
			Native.YGNodeLayoutGetBottomDelegateField = IL2CPP.ResolveICall<Native.YGNodeLayoutGetBottomDelegate>("UnityEngine.Yoga.Native::YGNodeLayoutGetBottom");
			Native.YGNodeLayoutGetWidthDelegateField = IL2CPP.ResolveICall<Native.YGNodeLayoutGetWidthDelegate>("UnityEngine.Yoga.Native::YGNodeLayoutGetWidth");
			Native.YGNodeLayoutGetHeightDelegateField = IL2CPP.ResolveICall<Native.YGNodeLayoutGetHeightDelegate>("UnityEngine.Yoga.Native::YGNodeLayoutGetHeight");
			Native.YGNodeLayoutGetMarginDelegateField = IL2CPP.ResolveICall<Native.YGNodeLayoutGetMarginDelegate>("UnityEngine.Yoga.Native::YGNodeLayoutGetMargin");
			Native.YGNodeLayoutGetPaddingDelegateField = IL2CPP.ResolveICall<Native.YGNodeLayoutGetPaddingDelegate>("UnityEngine.Yoga.Native::YGNodeLayoutGetPadding");
			Native.YGNodeLayoutGetDirectionDelegateField = IL2CPP.ResolveICall<Native.YGNodeLayoutGetDirectionDelegate>("UnityEngine.Yoga.Native::YGNodeLayoutGetDirection");
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0000367C File Offset: 0x0000187C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533441, XrefRangeEnd = 533442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeMeasureInvoke(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode, IntPtr returnValueAddress)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref widthMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref heightMode;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref returnValueAddress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeMeasureInvoke_Public_Static_Void_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000036F8 File Offset: 0x000018F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533442, XrefRangeEnd = 533443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeBaselineInvoke(YogaNode node, float width, float height, IntPtr returnValueAddress)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref returnValueAddress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeBaselineInvoke_Public_Static_Void_YogaNode_Single_Single_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000020B0 File Offset: 0x000002B0
		public Native(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000020B9 File Offset: 0x000002B9
		public static IntPtr YGNodeNew()
		{
			return Native.YGNodeNewDelegateField();
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000020C5 File Offset: 0x000002C5
		public static IntPtr YGNodeNewWithConfig(IntPtr config)
		{
			return Native.YGNodeNewWithConfigDelegateField(config);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00003758 File Offset: 0x00001958
		public static void YGNodeFree(IntPtr ygNode)
		{
			bool flag = ygNode == IntPtr.Zero;
			if (!flag)
			{
				Native.YGNodeFreeInternal(ygNode);
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000020D2 File Offset: 0x000002D2
		public static void YGNodeFreeInternal(IntPtr ygNode)
		{
			Native.YGNodeFreeInternalDelegateField(ygNode);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000020DF File Offset: 0x000002DF
		public static void YGNodeReset(IntPtr node)
		{
			Native.YGNodeResetDelegateField(node);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000020EC File Offset: 0x000002EC
		public static void YGSetManagedObject(IntPtr ygNode, YogaNode node)
		{
			Native.YGSetManagedObjectDelegateField(ygNode, IL2CPP.Il2CppObjectBaseToPtr(node));
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000020FF File Offset: 0x000002FF
		public static void YGNodeSetConfig(IntPtr ygNode, IntPtr config)
		{
			Native.YGNodeSetConfigDelegateField(ygNode, config);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000210D File Offset: 0x0000030D
		public static IntPtr YGConfigGetDefault()
		{
			return Native.YGConfigGetDefaultDelegateField();
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002119 File Offset: 0x00000319
		public static IntPtr YGConfigNew()
		{
			return Native.YGConfigNewDelegateField();
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003780 File Offset: 0x00001980
		public static void YGConfigFree(IntPtr config)
		{
			bool flag = config == IntPtr.Zero;
			if (!flag)
			{
				Native.YGConfigFreeInternal(config);
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002125 File Offset: 0x00000325
		public static void YGConfigFreeInternal(IntPtr config)
		{
			Native.YGConfigFreeInternalDelegateField(config);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002132 File Offset: 0x00000332
		public static int YGNodeGetInstanceCount()
		{
			return Native.YGNodeGetInstanceCountDelegateField();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0000213E File Offset: 0x0000033E
		public static int YGConfigGetInstanceCount()
		{
			return Native.YGConfigGetInstanceCountDelegateField();
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000214A File Offset: 0x0000034A
		public static void YGConfigSetExperimentalFeatureEnabled(IntPtr config, YogaExperimentalFeature feature, bool enabled)
		{
			Native.YGConfigSetExperimentalFeatureEnabledDelegateField(config, feature, enabled);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002159 File Offset: 0x00000359
		public static bool YGConfigIsExperimentalFeatureEnabled(IntPtr config, YogaExperimentalFeature feature)
		{
			return Native.YGConfigIsExperimentalFeatureEnabledDelegateField(config, feature);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002167 File Offset: 0x00000367
		public static void YGConfigSetUseWebDefaults(IntPtr config, bool useWebDefaults)
		{
			Native.YGConfigSetUseWebDefaultsDelegateField(config, useWebDefaults);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002175 File Offset: 0x00000375
		public static bool YGConfigGetUseWebDefaults(IntPtr config)
		{
			return Native.YGConfigGetUseWebDefaultsDelegateField(config);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002182 File Offset: 0x00000382
		public static void YGConfigSetPointScaleFactor(IntPtr config, float pixelsInPoint)
		{
			Native.YGConfigSetPointScaleFactorDelegateField(config, pixelsInPoint);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002190 File Offset: 0x00000390
		public static float YGConfigGetPointScaleFactor(IntPtr config)
		{
			return Native.YGConfigGetPointScaleFactorDelegateField(config);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000219D File Offset: 0x0000039D
		public static void YGNodeInsertChild(IntPtr node, IntPtr child, uint index)
		{
			Native.YGNodeInsertChildDelegateField(node, child, index);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000021AC File Offset: 0x000003AC
		public static void YGNodeRemoveChild(IntPtr node, IntPtr child)
		{
			Native.YGNodeRemoveChildDelegateField(node, child);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000021BA File Offset: 0x000003BA
		public static void YGNodeCalculateLayout(IntPtr node, float availableWidth, float availableHeight, YogaDirection parentDirection)
		{
			Native.YGNodeCalculateLayoutDelegateField(node, availableWidth, availableHeight, parentDirection);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000021CA File Offset: 0x000003CA
		public static void YGNodeMarkDirty(IntPtr node)
		{
			Native.YGNodeMarkDirtyDelegateField(node);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000021D7 File Offset: 0x000003D7
		public static bool YGNodeIsDirty(IntPtr node)
		{
			return Native.YGNodeIsDirtyDelegateField(node);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000021E4 File Offset: 0x000003E4
		public static void YGNodePrint(IntPtr node, YogaPrintOptions options)
		{
			Native.YGNodePrintDelegateField(node, options);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000021F2 File Offset: 0x000003F2
		public static void YGNodeCopyStyle(IntPtr dstNode, IntPtr srcNode)
		{
			Native.YGNodeCopyStyleDelegateField(dstNode, srcNode);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002200 File Offset: 0x00000400
		public static void YGNodeSetMeasureFunc(IntPtr node)
		{
			Native.YGNodeSetMeasureFuncDelegateField(node);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000220D File Offset: 0x0000040D
		public static void YGNodeRemoveMeasureFunc(IntPtr node)
		{
			Native.YGNodeRemoveMeasureFuncDelegateField(node);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000221A File Offset: 0x0000041A
		public static void YGNodeSetBaselineFunc(IntPtr node)
		{
			Native.YGNodeSetBaselineFuncDelegateField(node);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002227 File Offset: 0x00000427
		public static void YGNodeRemoveBaselineFunc(IntPtr node)
		{
			Native.YGNodeRemoveBaselineFuncDelegateField(node);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002234 File Offset: 0x00000434
		public static void YGNodeSetHasNewLayout(IntPtr node, bool hasNewLayout)
		{
			Native.YGNodeSetHasNewLayoutDelegateField(node, hasNewLayout);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002242 File Offset: 0x00000442
		public static bool YGNodeGetHasNewLayout(IntPtr node)
		{
			return Native.YGNodeGetHasNewLayoutDelegateField(node);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000224F File Offset: 0x0000044F
		public static void YGNodeStyleSetDirection(IntPtr node, YogaDirection direction)
		{
			Native.YGNodeStyleSetDirectionDelegateField(node, direction);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000225D File Offset: 0x0000045D
		public static YogaDirection YGNodeStyleGetDirection(IntPtr node)
		{
			return Native.YGNodeStyleGetDirectionDelegateField(node);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000226A File Offset: 0x0000046A
		public static void YGNodeStyleSetFlexDirection(IntPtr node, YogaFlexDirection flexDirection)
		{
			Native.YGNodeStyleSetFlexDirectionDelegateField(node, flexDirection);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002278 File Offset: 0x00000478
		public static YogaFlexDirection YGNodeStyleGetFlexDirection(IntPtr node)
		{
			return Native.YGNodeStyleGetFlexDirectionDelegateField(node);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002285 File Offset: 0x00000485
		public static void YGNodeStyleSetJustifyContent(IntPtr node, YogaJustify justifyContent)
		{
			Native.YGNodeStyleSetJustifyContentDelegateField(node, justifyContent);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002293 File Offset: 0x00000493
		public static YogaJustify YGNodeStyleGetJustifyContent(IntPtr node)
		{
			return Native.YGNodeStyleGetJustifyContentDelegateField(node);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000022A0 File Offset: 0x000004A0
		public static void YGNodeStyleSetAlignContent(IntPtr node, YogaAlign alignContent)
		{
			Native.YGNodeStyleSetAlignContentDelegateField(node, alignContent);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000022AE File Offset: 0x000004AE
		public static YogaAlign YGNodeStyleGetAlignContent(IntPtr node)
		{
			return Native.YGNodeStyleGetAlignContentDelegateField(node);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000022BB File Offset: 0x000004BB
		public static void YGNodeStyleSetAlignItems(IntPtr node, YogaAlign alignItems)
		{
			Native.YGNodeStyleSetAlignItemsDelegateField(node, alignItems);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000022C9 File Offset: 0x000004C9
		public static YogaAlign YGNodeStyleGetAlignItems(IntPtr node)
		{
			return Native.YGNodeStyleGetAlignItemsDelegateField(node);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000022D6 File Offset: 0x000004D6
		public static void YGNodeStyleSetAlignSelf(IntPtr node, YogaAlign alignSelf)
		{
			Native.YGNodeStyleSetAlignSelfDelegateField(node, alignSelf);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000022E4 File Offset: 0x000004E4
		public static YogaAlign YGNodeStyleGetAlignSelf(IntPtr node)
		{
			return Native.YGNodeStyleGetAlignSelfDelegateField(node);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000022F1 File Offset: 0x000004F1
		public static void YGNodeStyleSetPositionType(IntPtr node, YogaPositionType positionType)
		{
			Native.YGNodeStyleSetPositionTypeDelegateField(node, positionType);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000022FF File Offset: 0x000004FF
		public static YogaPositionType YGNodeStyleGetPositionType(IntPtr node)
		{
			return Native.YGNodeStyleGetPositionTypeDelegateField(node);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000230C File Offset: 0x0000050C
		public static void YGNodeStyleSetFlexWrap(IntPtr node, YogaWrap flexWrap)
		{
			Native.YGNodeStyleSetFlexWrapDelegateField(node, flexWrap);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000231A File Offset: 0x0000051A
		public static YogaWrap YGNodeStyleGetFlexWrap(IntPtr node)
		{
			return Native.YGNodeStyleGetFlexWrapDelegateField(node);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002327 File Offset: 0x00000527
		public static void YGNodeStyleSetOverflow(IntPtr node, YogaOverflow flexWrap)
		{
			Native.YGNodeStyleSetOverflowDelegateField(node, flexWrap);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002335 File Offset: 0x00000535
		public static YogaOverflow YGNodeStyleGetOverflow(IntPtr node)
		{
			return Native.YGNodeStyleGetOverflowDelegateField(node);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002342 File Offset: 0x00000542
		public static void YGNodeStyleSetDisplay(IntPtr node, YogaDisplay display)
		{
			Native.YGNodeStyleSetDisplayDelegateField(node, display);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002350 File Offset: 0x00000550
		public static YogaDisplay YGNodeStyleGetDisplay(IntPtr node)
		{
			return Native.YGNodeStyleGetDisplayDelegateField(node);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000235D File Offset: 0x0000055D
		public static void YGNodeStyleSetFlex(IntPtr node, float flex)
		{
			Native.YGNodeStyleSetFlexDelegateField(node, flex);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000236B File Offset: 0x0000056B
		public static void YGNodeStyleSetFlexGrow(IntPtr node, float flexGrow)
		{
			Native.YGNodeStyleSetFlexGrowDelegateField(node, flexGrow);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002379 File Offset: 0x00000579
		public static float YGNodeStyleGetFlexGrow(IntPtr node)
		{
			return Native.YGNodeStyleGetFlexGrowDelegateField(node);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002386 File Offset: 0x00000586
		public static void YGNodeStyleSetFlexShrink(IntPtr node, float flexShrink)
		{
			Native.YGNodeStyleSetFlexShrinkDelegateField(node, flexShrink);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002394 File Offset: 0x00000594
		public static float YGNodeStyleGetFlexShrink(IntPtr node)
		{
			return Native.YGNodeStyleGetFlexShrinkDelegateField(node);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000023A1 File Offset: 0x000005A1
		public static void YGNodeStyleSetFlexBasis(IntPtr node, float flexBasis)
		{
			Native.YGNodeStyleSetFlexBasisDelegateField(node, flexBasis);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000023AF File Offset: 0x000005AF
		public static void YGNodeStyleSetFlexBasisPercent(IntPtr node, float flexBasis)
		{
			Native.YGNodeStyleSetFlexBasisPercentDelegateField(node, flexBasis);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000023BD File Offset: 0x000005BD
		public static void YGNodeStyleSetFlexBasisAuto(IntPtr node)
		{
			Native.YGNodeStyleSetFlexBasisAutoDelegateField(node);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000023CA File Offset: 0x000005CA
		public static float YGNodeGetComputedFlexBasis(IntPtr node)
		{
			return Native.YGNodeGetComputedFlexBasisDelegateField(node);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000023D7 File Offset: 0x000005D7
		public static void YGNodeStyleSetWidth(IntPtr node, float width)
		{
			Native.YGNodeStyleSetWidthDelegateField(node, width);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000023E5 File Offset: 0x000005E5
		public static void YGNodeStyleSetWidthPercent(IntPtr node, float width)
		{
			Native.YGNodeStyleSetWidthPercentDelegateField(node, width);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000023F3 File Offset: 0x000005F3
		public static void YGNodeStyleSetWidthAuto(IntPtr node)
		{
			Native.YGNodeStyleSetWidthAutoDelegateField(node);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002400 File Offset: 0x00000600
		public static void YGNodeStyleSetHeight(IntPtr node, float height)
		{
			Native.YGNodeStyleSetHeightDelegateField(node, height);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000240E File Offset: 0x0000060E
		public static void YGNodeStyleSetHeightPercent(IntPtr node, float height)
		{
			Native.YGNodeStyleSetHeightPercentDelegateField(node, height);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000241C File Offset: 0x0000061C
		public static void YGNodeStyleSetHeightAuto(IntPtr node)
		{
			Native.YGNodeStyleSetHeightAutoDelegateField(node);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002429 File Offset: 0x00000629
		public static void YGNodeStyleSetMinWidth(IntPtr node, float minWidth)
		{
			Native.YGNodeStyleSetMinWidthDelegateField(node, minWidth);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002437 File Offset: 0x00000637
		public static void YGNodeStyleSetMinWidthPercent(IntPtr node, float minWidth)
		{
			Native.YGNodeStyleSetMinWidthPercentDelegateField(node, minWidth);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002445 File Offset: 0x00000645
		public static void YGNodeStyleSetMinHeight(IntPtr node, float minHeight)
		{
			Native.YGNodeStyleSetMinHeightDelegateField(node, minHeight);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002453 File Offset: 0x00000653
		public static void YGNodeStyleSetMinHeightPercent(IntPtr node, float minHeight)
		{
			Native.YGNodeStyleSetMinHeightPercentDelegateField(node, minHeight);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002461 File Offset: 0x00000661
		public static void YGNodeStyleSetMaxWidth(IntPtr node, float maxWidth)
		{
			Native.YGNodeStyleSetMaxWidthDelegateField(node, maxWidth);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000246F File Offset: 0x0000066F
		public static void YGNodeStyleSetMaxWidthPercent(IntPtr node, float maxWidth)
		{
			Native.YGNodeStyleSetMaxWidthPercentDelegateField(node, maxWidth);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000247D File Offset: 0x0000067D
		public static void YGNodeStyleSetMaxHeight(IntPtr node, float maxHeight)
		{
			Native.YGNodeStyleSetMaxHeightDelegateField(node, maxHeight);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000248B File Offset: 0x0000068B
		public static void YGNodeStyleSetMaxHeightPercent(IntPtr node, float maxHeight)
		{
			Native.YGNodeStyleSetMaxHeightPercentDelegateField(node, maxHeight);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002499 File Offset: 0x00000699
		public static void YGNodeStyleSetAspectRatio(IntPtr node, float aspectRatio)
		{
			Native.YGNodeStyleSetAspectRatioDelegateField(node, aspectRatio);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000024A7 File Offset: 0x000006A7
		public static float YGNodeStyleGetAspectRatio(IntPtr node)
		{
			return Native.YGNodeStyleGetAspectRatioDelegateField(node);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000024B4 File Offset: 0x000006B4
		public static void YGNodeStyleSetPosition(IntPtr node, YogaEdge edge, float position)
		{
			Native.YGNodeStyleSetPositionDelegateField(node, edge, position);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000024C3 File Offset: 0x000006C3
		public static void YGNodeStyleSetPositionPercent(IntPtr node, YogaEdge edge, float position)
		{
			Native.YGNodeStyleSetPositionPercentDelegateField(node, edge, position);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000024D2 File Offset: 0x000006D2
		public static void YGNodeStyleSetMargin(IntPtr node, YogaEdge edge, float margin)
		{
			Native.YGNodeStyleSetMarginDelegateField(node, edge, margin);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000024E1 File Offset: 0x000006E1
		public static void YGNodeStyleSetMarginPercent(IntPtr node, YogaEdge edge, float margin)
		{
			Native.YGNodeStyleSetMarginPercentDelegateField(node, edge, margin);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000024F0 File Offset: 0x000006F0
		public static void YGNodeStyleSetMarginAuto(IntPtr node, YogaEdge edge)
		{
			Native.YGNodeStyleSetMarginAutoDelegateField(node, edge);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000024FE File Offset: 0x000006FE
		public static void YGNodeStyleSetPadding(IntPtr node, YogaEdge edge, float padding)
		{
			Native.YGNodeStyleSetPaddingDelegateField(node, edge, padding);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000250D File Offset: 0x0000070D
		public static void YGNodeStyleSetPaddingPercent(IntPtr node, YogaEdge edge, float padding)
		{
			Native.YGNodeStyleSetPaddingPercentDelegateField(node, edge, padding);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000251C File Offset: 0x0000071C
		public static void YGNodeStyleSetBorder(IntPtr node, YogaEdge edge, float border)
		{
			Native.YGNodeStyleSetBorderDelegateField(node, edge, border);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000252B File Offset: 0x0000072B
		public static float YGNodeStyleGetBorder(IntPtr node, YogaEdge edge)
		{
			return Native.YGNodeStyleGetBorderDelegateField(node, edge);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002539 File Offset: 0x00000739
		public static float YGNodeLayoutGetLeft(IntPtr node)
		{
			return Native.YGNodeLayoutGetLeftDelegateField(node);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002546 File Offset: 0x00000746
		public static float YGNodeLayoutGetTop(IntPtr node)
		{
			return Native.YGNodeLayoutGetTopDelegateField(node);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002553 File Offset: 0x00000753
		public static float YGNodeLayoutGetRight(IntPtr node)
		{
			return Native.YGNodeLayoutGetRightDelegateField(node);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002560 File Offset: 0x00000760
		public static float YGNodeLayoutGetBottom(IntPtr node)
		{
			return Native.YGNodeLayoutGetBottomDelegateField(node);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000256D File Offset: 0x0000076D
		public static float YGNodeLayoutGetWidth(IntPtr node)
		{
			return Native.YGNodeLayoutGetWidthDelegateField(node);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000257A File Offset: 0x0000077A
		public static float YGNodeLayoutGetHeight(IntPtr node)
		{
			return Native.YGNodeLayoutGetHeightDelegateField(node);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002587 File Offset: 0x00000787
		public static float YGNodeLayoutGetMargin(IntPtr node, YogaEdge edge)
		{
			return Native.YGNodeLayoutGetMarginDelegateField(node, edge);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002595 File Offset: 0x00000795
		public static float YGNodeLayoutGetPadding(IntPtr node, YogaEdge edge)
		{
			return Native.YGNodeLayoutGetPaddingDelegateField(node, edge);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000025A3 File Offset: 0x000007A3
		public static YogaDirection YGNodeLayoutGetDirection(IntPtr node)
		{
			return Native.YGNodeLayoutGetDirectionDelegateField(node);
		}

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeMeasureInvoke_Public_Static_Void_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode_IntPtr_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeBaselineInvoke_Public_Static_Void_YogaNode_Single_Single_IntPtr_0;

		// Token: 0x0400000F RID: 15
		private static readonly Native.YGNodeNewDelegate YGNodeNewDelegateField;

		// Token: 0x04000010 RID: 16
		private static readonly Native.YGNodeNewWithConfigDelegate YGNodeNewWithConfigDelegateField;

		// Token: 0x04000011 RID: 17
		private static readonly Native.YGNodeFreeInternalDelegate YGNodeFreeInternalDelegateField;

		// Token: 0x04000012 RID: 18
		private static readonly Native.YGNodeResetDelegate YGNodeResetDelegateField;

		// Token: 0x04000013 RID: 19
		private static readonly Native.YGSetManagedObjectDelegate YGSetManagedObjectDelegateField;

		// Token: 0x04000014 RID: 20
		private static readonly Native.YGNodeSetConfigDelegate YGNodeSetConfigDelegateField;

		// Token: 0x04000015 RID: 21
		private static readonly Native.YGConfigGetDefaultDelegate YGConfigGetDefaultDelegateField;

		// Token: 0x04000016 RID: 22
		private static readonly Native.YGConfigNewDelegate YGConfigNewDelegateField;

		// Token: 0x04000017 RID: 23
		private static readonly Native.YGConfigFreeInternalDelegate YGConfigFreeInternalDelegateField;

		// Token: 0x04000018 RID: 24
		private static readonly Native.YGNodeGetInstanceCountDelegate YGNodeGetInstanceCountDelegateField;

		// Token: 0x04000019 RID: 25
		private static readonly Native.YGConfigGetInstanceCountDelegate YGConfigGetInstanceCountDelegateField;

		// Token: 0x0400001A RID: 26
		private static readonly Native.YGConfigSetExperimentalFeatureEnabledDelegate YGConfigSetExperimentalFeatureEnabledDelegateField;

		// Token: 0x0400001B RID: 27
		private static readonly Native.YGConfigIsExperimentalFeatureEnabledDelegate YGConfigIsExperimentalFeatureEnabledDelegateField;

		// Token: 0x0400001C RID: 28
		private static readonly Native.YGConfigSetUseWebDefaultsDelegate YGConfigSetUseWebDefaultsDelegateField;

		// Token: 0x0400001D RID: 29
		private static readonly Native.YGConfigGetUseWebDefaultsDelegate YGConfigGetUseWebDefaultsDelegateField;

		// Token: 0x0400001E RID: 30
		private static readonly Native.YGConfigSetPointScaleFactorDelegate YGConfigSetPointScaleFactorDelegateField;

		// Token: 0x0400001F RID: 31
		private static readonly Native.YGConfigGetPointScaleFactorDelegate YGConfigGetPointScaleFactorDelegateField;

		// Token: 0x04000020 RID: 32
		private static readonly Native.YGNodeInsertChildDelegate YGNodeInsertChildDelegateField;

		// Token: 0x04000021 RID: 33
		private static readonly Native.YGNodeRemoveChildDelegate YGNodeRemoveChildDelegateField;

		// Token: 0x04000022 RID: 34
		private static readonly Native.YGNodeCalculateLayoutDelegate YGNodeCalculateLayoutDelegateField;

		// Token: 0x04000023 RID: 35
		private static readonly Native.YGNodeMarkDirtyDelegate YGNodeMarkDirtyDelegateField;

		// Token: 0x04000024 RID: 36
		private static readonly Native.YGNodeIsDirtyDelegate YGNodeIsDirtyDelegateField;

		// Token: 0x04000025 RID: 37
		private static readonly Native.YGNodePrintDelegate YGNodePrintDelegateField;

		// Token: 0x04000026 RID: 38
		private static readonly Native.YGNodeCopyStyleDelegate YGNodeCopyStyleDelegateField;

		// Token: 0x04000027 RID: 39
		private static readonly Native.YGNodeSetMeasureFuncDelegate YGNodeSetMeasureFuncDelegateField;

		// Token: 0x04000028 RID: 40
		private static readonly Native.YGNodeRemoveMeasureFuncDelegate YGNodeRemoveMeasureFuncDelegateField;

		// Token: 0x04000029 RID: 41
		private static readonly Native.YGNodeSetBaselineFuncDelegate YGNodeSetBaselineFuncDelegateField;

		// Token: 0x0400002A RID: 42
		private static readonly Native.YGNodeRemoveBaselineFuncDelegate YGNodeRemoveBaselineFuncDelegateField;

		// Token: 0x0400002B RID: 43
		private static readonly Native.YGNodeSetHasNewLayoutDelegate YGNodeSetHasNewLayoutDelegateField;

		// Token: 0x0400002C RID: 44
		private static readonly Native.YGNodeGetHasNewLayoutDelegate YGNodeGetHasNewLayoutDelegateField;

		// Token: 0x0400002D RID: 45
		private static readonly Native.YGNodeStyleSetDirectionDelegate YGNodeStyleSetDirectionDelegateField;

		// Token: 0x0400002E RID: 46
		private static readonly Native.YGNodeStyleGetDirectionDelegate YGNodeStyleGetDirectionDelegateField;

		// Token: 0x0400002F RID: 47
		private static readonly Native.YGNodeStyleSetFlexDirectionDelegate YGNodeStyleSetFlexDirectionDelegateField;

		// Token: 0x04000030 RID: 48
		private static readonly Native.YGNodeStyleGetFlexDirectionDelegate YGNodeStyleGetFlexDirectionDelegateField;

		// Token: 0x04000031 RID: 49
		private static readonly Native.YGNodeStyleSetJustifyContentDelegate YGNodeStyleSetJustifyContentDelegateField;

		// Token: 0x04000032 RID: 50
		private static readonly Native.YGNodeStyleGetJustifyContentDelegate YGNodeStyleGetJustifyContentDelegateField;

		// Token: 0x04000033 RID: 51
		private static readonly Native.YGNodeStyleSetAlignContentDelegate YGNodeStyleSetAlignContentDelegateField;

		// Token: 0x04000034 RID: 52
		private static readonly Native.YGNodeStyleGetAlignContentDelegate YGNodeStyleGetAlignContentDelegateField;

		// Token: 0x04000035 RID: 53
		private static readonly Native.YGNodeStyleSetAlignItemsDelegate YGNodeStyleSetAlignItemsDelegateField;

		// Token: 0x04000036 RID: 54
		private static readonly Native.YGNodeStyleGetAlignItemsDelegate YGNodeStyleGetAlignItemsDelegateField;

		// Token: 0x04000037 RID: 55
		private static readonly Native.YGNodeStyleSetAlignSelfDelegate YGNodeStyleSetAlignSelfDelegateField;

		// Token: 0x04000038 RID: 56
		private static readonly Native.YGNodeStyleGetAlignSelfDelegate YGNodeStyleGetAlignSelfDelegateField;

		// Token: 0x04000039 RID: 57
		private static readonly Native.YGNodeStyleSetPositionTypeDelegate YGNodeStyleSetPositionTypeDelegateField;

		// Token: 0x0400003A RID: 58
		private static readonly Native.YGNodeStyleGetPositionTypeDelegate YGNodeStyleGetPositionTypeDelegateField;

		// Token: 0x0400003B RID: 59
		private static readonly Native.YGNodeStyleSetFlexWrapDelegate YGNodeStyleSetFlexWrapDelegateField;

		// Token: 0x0400003C RID: 60
		private static readonly Native.YGNodeStyleGetFlexWrapDelegate YGNodeStyleGetFlexWrapDelegateField;

		// Token: 0x0400003D RID: 61
		private static readonly Native.YGNodeStyleSetOverflowDelegate YGNodeStyleSetOverflowDelegateField;

		// Token: 0x0400003E RID: 62
		private static readonly Native.YGNodeStyleGetOverflowDelegate YGNodeStyleGetOverflowDelegateField;

		// Token: 0x0400003F RID: 63
		private static readonly Native.YGNodeStyleSetDisplayDelegate YGNodeStyleSetDisplayDelegateField;

		// Token: 0x04000040 RID: 64
		private static readonly Native.YGNodeStyleGetDisplayDelegate YGNodeStyleGetDisplayDelegateField;

		// Token: 0x04000041 RID: 65
		private static readonly Native.YGNodeStyleSetFlexDelegate YGNodeStyleSetFlexDelegateField;

		// Token: 0x04000042 RID: 66
		private static readonly Native.YGNodeStyleSetFlexGrowDelegate YGNodeStyleSetFlexGrowDelegateField;

		// Token: 0x04000043 RID: 67
		private static readonly Native.YGNodeStyleGetFlexGrowDelegate YGNodeStyleGetFlexGrowDelegateField;

		// Token: 0x04000044 RID: 68
		private static readonly Native.YGNodeStyleSetFlexShrinkDelegate YGNodeStyleSetFlexShrinkDelegateField;

		// Token: 0x04000045 RID: 69
		private static readonly Native.YGNodeStyleGetFlexShrinkDelegate YGNodeStyleGetFlexShrinkDelegateField;

		// Token: 0x04000046 RID: 70
		private static readonly Native.YGNodeStyleSetFlexBasisDelegate YGNodeStyleSetFlexBasisDelegateField;

		// Token: 0x04000047 RID: 71
		private static readonly Native.YGNodeStyleSetFlexBasisPercentDelegate YGNodeStyleSetFlexBasisPercentDelegateField;

		// Token: 0x04000048 RID: 72
		private static readonly Native.YGNodeStyleSetFlexBasisAutoDelegate YGNodeStyleSetFlexBasisAutoDelegateField;

		// Token: 0x04000049 RID: 73
		private static readonly Native.YGNodeGetComputedFlexBasisDelegate YGNodeGetComputedFlexBasisDelegateField;

		// Token: 0x0400004A RID: 74
		private static readonly Native.YGNodeStyleSetWidthDelegate YGNodeStyleSetWidthDelegateField;

		// Token: 0x0400004B RID: 75
		private static readonly Native.YGNodeStyleSetWidthPercentDelegate YGNodeStyleSetWidthPercentDelegateField;

		// Token: 0x0400004C RID: 76
		private static readonly Native.YGNodeStyleSetWidthAutoDelegate YGNodeStyleSetWidthAutoDelegateField;

		// Token: 0x0400004D RID: 77
		private static readonly Native.YGNodeStyleSetHeightDelegate YGNodeStyleSetHeightDelegateField;

		// Token: 0x0400004E RID: 78
		private static readonly Native.YGNodeStyleSetHeightPercentDelegate YGNodeStyleSetHeightPercentDelegateField;

		// Token: 0x0400004F RID: 79
		private static readonly Native.YGNodeStyleSetHeightAutoDelegate YGNodeStyleSetHeightAutoDelegateField;

		// Token: 0x04000050 RID: 80
		private static readonly Native.YGNodeStyleSetMinWidthDelegate YGNodeStyleSetMinWidthDelegateField;

		// Token: 0x04000051 RID: 81
		private static readonly Native.YGNodeStyleSetMinWidthPercentDelegate YGNodeStyleSetMinWidthPercentDelegateField;

		// Token: 0x04000052 RID: 82
		private static readonly Native.YGNodeStyleSetMinHeightDelegate YGNodeStyleSetMinHeightDelegateField;

		// Token: 0x04000053 RID: 83
		private static readonly Native.YGNodeStyleSetMinHeightPercentDelegate YGNodeStyleSetMinHeightPercentDelegateField;

		// Token: 0x04000054 RID: 84
		private static readonly Native.YGNodeStyleSetMaxWidthDelegate YGNodeStyleSetMaxWidthDelegateField;

		// Token: 0x04000055 RID: 85
		private static readonly Native.YGNodeStyleSetMaxWidthPercentDelegate YGNodeStyleSetMaxWidthPercentDelegateField;

		// Token: 0x04000056 RID: 86
		private static readonly Native.YGNodeStyleSetMaxHeightDelegate YGNodeStyleSetMaxHeightDelegateField;

		// Token: 0x04000057 RID: 87
		private static readonly Native.YGNodeStyleSetMaxHeightPercentDelegate YGNodeStyleSetMaxHeightPercentDelegateField;

		// Token: 0x04000058 RID: 88
		private static readonly Native.YGNodeStyleSetAspectRatioDelegate YGNodeStyleSetAspectRatioDelegateField;

		// Token: 0x04000059 RID: 89
		private static readonly Native.YGNodeStyleGetAspectRatioDelegate YGNodeStyleGetAspectRatioDelegateField;

		// Token: 0x0400005A RID: 90
		private static readonly Native.YGNodeStyleSetPositionDelegate YGNodeStyleSetPositionDelegateField;

		// Token: 0x0400005B RID: 91
		private static readonly Native.YGNodeStyleSetPositionPercentDelegate YGNodeStyleSetPositionPercentDelegateField;

		// Token: 0x0400005C RID: 92
		private static readonly Native.YGNodeStyleSetMarginDelegate YGNodeStyleSetMarginDelegateField;

		// Token: 0x0400005D RID: 93
		private static readonly Native.YGNodeStyleSetMarginPercentDelegate YGNodeStyleSetMarginPercentDelegateField;

		// Token: 0x0400005E RID: 94
		private static readonly Native.YGNodeStyleSetMarginAutoDelegate YGNodeStyleSetMarginAutoDelegateField;

		// Token: 0x0400005F RID: 95
		private static readonly Native.YGNodeStyleSetPaddingDelegate YGNodeStyleSetPaddingDelegateField;

		// Token: 0x04000060 RID: 96
		private static readonly Native.YGNodeStyleSetPaddingPercentDelegate YGNodeStyleSetPaddingPercentDelegateField;

		// Token: 0x04000061 RID: 97
		private static readonly Native.YGNodeStyleSetBorderDelegate YGNodeStyleSetBorderDelegateField;

		// Token: 0x04000062 RID: 98
		private static readonly Native.YGNodeStyleGetBorderDelegate YGNodeStyleGetBorderDelegateField;

		// Token: 0x04000063 RID: 99
		private static readonly Native.YGNodeLayoutGetLeftDelegate YGNodeLayoutGetLeftDelegateField;

		// Token: 0x04000064 RID: 100
		private static readonly Native.YGNodeLayoutGetTopDelegate YGNodeLayoutGetTopDelegateField;

		// Token: 0x04000065 RID: 101
		private static readonly Native.YGNodeLayoutGetRightDelegate YGNodeLayoutGetRightDelegateField;

		// Token: 0x04000066 RID: 102
		private static readonly Native.YGNodeLayoutGetBottomDelegate YGNodeLayoutGetBottomDelegateField;

		// Token: 0x04000067 RID: 103
		private static readonly Native.YGNodeLayoutGetWidthDelegate YGNodeLayoutGetWidthDelegateField;

		// Token: 0x04000068 RID: 104
		private static readonly Native.YGNodeLayoutGetHeightDelegate YGNodeLayoutGetHeightDelegateField;

		// Token: 0x04000069 RID: 105
		private static readonly Native.YGNodeLayoutGetMarginDelegate YGNodeLayoutGetMarginDelegateField;

		// Token: 0x0400006A RID: 106
		private static readonly Native.YGNodeLayoutGetPaddingDelegate YGNodeLayoutGetPaddingDelegateField;

		// Token: 0x0400006B RID: 107
		private static readonly Native.YGNodeLayoutGetDirectionDelegate YGNodeLayoutGetDirectionDelegateField;

		// Token: 0x02000020 RID: 32
		// (Invoke) Token: 0x0600013D RID: 317
		private delegate IntPtr YGNodeNewDelegate();

		// Token: 0x02000021 RID: 33
		// (Invoke) Token: 0x0600013F RID: 319
		private delegate IntPtr YGNodeNewWithConfigDelegate(IntPtr config);

		// Token: 0x02000022 RID: 34
		// (Invoke) Token: 0x06000141 RID: 321
		private delegate void YGNodeFreeInternalDelegate(IntPtr ygNode);

		// Token: 0x02000023 RID: 35
		// (Invoke) Token: 0x06000143 RID: 323
		private delegate void YGNodeResetDelegate(IntPtr node);

		// Token: 0x02000024 RID: 36
		// (Invoke) Token: 0x06000145 RID: 325
		private delegate void YGSetManagedObjectDelegate(IntPtr ygNode, IntPtr node);

		// Token: 0x02000025 RID: 37
		// (Invoke) Token: 0x06000147 RID: 327
		private delegate void YGNodeSetConfigDelegate(IntPtr ygNode, IntPtr config);

		// Token: 0x02000026 RID: 38
		// (Invoke) Token: 0x06000149 RID: 329
		private delegate IntPtr YGConfigGetDefaultDelegate();

		// Token: 0x02000027 RID: 39
		// (Invoke) Token: 0x0600014B RID: 331
		private delegate IntPtr YGConfigNewDelegate();

		// Token: 0x02000028 RID: 40
		// (Invoke) Token: 0x0600014D RID: 333
		private delegate void YGConfigFreeInternalDelegate(IntPtr config);

		// Token: 0x02000029 RID: 41
		// (Invoke) Token: 0x0600014F RID: 335
		private delegate int YGNodeGetInstanceCountDelegate();

		// Token: 0x0200002A RID: 42
		// (Invoke) Token: 0x06000151 RID: 337
		private delegate int YGConfigGetInstanceCountDelegate();

		// Token: 0x0200002B RID: 43
		// (Invoke) Token: 0x06000153 RID: 339
		private delegate void YGConfigSetExperimentalFeatureEnabledDelegate(IntPtr config, YogaExperimentalFeature feature, bool enabled);

		// Token: 0x0200002C RID: 44
		// (Invoke) Token: 0x06000155 RID: 341
		private delegate bool YGConfigIsExperimentalFeatureEnabledDelegate(IntPtr config, YogaExperimentalFeature feature);

		// Token: 0x0200002D RID: 45
		// (Invoke) Token: 0x06000157 RID: 343
		private delegate void YGConfigSetUseWebDefaultsDelegate(IntPtr config, bool useWebDefaults);

		// Token: 0x0200002E RID: 46
		// (Invoke) Token: 0x06000159 RID: 345
		private delegate bool YGConfigGetUseWebDefaultsDelegate(IntPtr config);

		// Token: 0x0200002F RID: 47
		// (Invoke) Token: 0x0600015B RID: 347
		private delegate void YGConfigSetPointScaleFactorDelegate(IntPtr config, float pixelsInPoint);

		// Token: 0x02000030 RID: 48
		// (Invoke) Token: 0x0600015D RID: 349
		private delegate float YGConfigGetPointScaleFactorDelegate(IntPtr config);

		// Token: 0x02000031 RID: 49
		// (Invoke) Token: 0x0600015F RID: 351
		private delegate void YGNodeInsertChildDelegate(IntPtr node, IntPtr child, uint index);

		// Token: 0x02000032 RID: 50
		// (Invoke) Token: 0x06000161 RID: 353
		private delegate void YGNodeRemoveChildDelegate(IntPtr node, IntPtr child);

		// Token: 0x02000033 RID: 51
		// (Invoke) Token: 0x06000163 RID: 355
		private delegate void YGNodeCalculateLayoutDelegate(IntPtr node, float availableWidth, float availableHeight, YogaDirection parentDirection);

		// Token: 0x02000034 RID: 52
		// (Invoke) Token: 0x06000165 RID: 357
		private delegate void YGNodeMarkDirtyDelegate(IntPtr node);

		// Token: 0x02000035 RID: 53
		// (Invoke) Token: 0x06000167 RID: 359
		private delegate bool YGNodeIsDirtyDelegate(IntPtr node);

		// Token: 0x02000036 RID: 54
		// (Invoke) Token: 0x06000169 RID: 361
		private delegate void YGNodePrintDelegate(IntPtr node, YogaPrintOptions options);

		// Token: 0x02000037 RID: 55
		// (Invoke) Token: 0x0600016B RID: 363
		private delegate void YGNodeCopyStyleDelegate(IntPtr dstNode, IntPtr srcNode);

		// Token: 0x02000038 RID: 56
		// (Invoke) Token: 0x0600016D RID: 365
		private delegate void YGNodeSetMeasureFuncDelegate(IntPtr node);

		// Token: 0x02000039 RID: 57
		// (Invoke) Token: 0x0600016F RID: 367
		private delegate void YGNodeRemoveMeasureFuncDelegate(IntPtr node);

		// Token: 0x0200003A RID: 58
		// (Invoke) Token: 0x06000171 RID: 369
		private delegate void YGNodeSetBaselineFuncDelegate(IntPtr node);

		// Token: 0x0200003B RID: 59
		// (Invoke) Token: 0x06000173 RID: 371
		private delegate void YGNodeRemoveBaselineFuncDelegate(IntPtr node);

		// Token: 0x0200003C RID: 60
		// (Invoke) Token: 0x06000175 RID: 373
		private delegate void YGNodeSetHasNewLayoutDelegate(IntPtr node, bool hasNewLayout);

		// Token: 0x0200003D RID: 61
		// (Invoke) Token: 0x06000177 RID: 375
		private delegate bool YGNodeGetHasNewLayoutDelegate(IntPtr node);

		// Token: 0x0200003E RID: 62
		// (Invoke) Token: 0x06000179 RID: 377
		private delegate void YGNodeStyleSetDirectionDelegate(IntPtr node, YogaDirection direction);

		// Token: 0x0200003F RID: 63
		// (Invoke) Token: 0x0600017B RID: 379
		private delegate YogaDirection YGNodeStyleGetDirectionDelegate(IntPtr node);

		// Token: 0x02000040 RID: 64
		// (Invoke) Token: 0x0600017D RID: 381
		private delegate void YGNodeStyleSetFlexDirectionDelegate(IntPtr node, YogaFlexDirection flexDirection);

		// Token: 0x02000041 RID: 65
		// (Invoke) Token: 0x0600017F RID: 383
		private delegate YogaFlexDirection YGNodeStyleGetFlexDirectionDelegate(IntPtr node);

		// Token: 0x02000042 RID: 66
		// (Invoke) Token: 0x06000181 RID: 385
		private delegate void YGNodeStyleSetJustifyContentDelegate(IntPtr node, YogaJustify justifyContent);

		// Token: 0x02000043 RID: 67
		// (Invoke) Token: 0x06000183 RID: 387
		private delegate YogaJustify YGNodeStyleGetJustifyContentDelegate(IntPtr node);

		// Token: 0x02000044 RID: 68
		// (Invoke) Token: 0x06000185 RID: 389
		private delegate void YGNodeStyleSetAlignContentDelegate(IntPtr node, YogaAlign alignContent);

		// Token: 0x02000045 RID: 69
		// (Invoke) Token: 0x06000187 RID: 391
		private delegate YogaAlign YGNodeStyleGetAlignContentDelegate(IntPtr node);

		// Token: 0x02000046 RID: 70
		// (Invoke) Token: 0x06000189 RID: 393
		private delegate void YGNodeStyleSetAlignItemsDelegate(IntPtr node, YogaAlign alignItems);

		// Token: 0x02000047 RID: 71
		// (Invoke) Token: 0x0600018B RID: 395
		private delegate YogaAlign YGNodeStyleGetAlignItemsDelegate(IntPtr node);

		// Token: 0x02000048 RID: 72
		// (Invoke) Token: 0x0600018D RID: 397
		private delegate void YGNodeStyleSetAlignSelfDelegate(IntPtr node, YogaAlign alignSelf);

		// Token: 0x02000049 RID: 73
		// (Invoke) Token: 0x0600018F RID: 399
		private delegate YogaAlign YGNodeStyleGetAlignSelfDelegate(IntPtr node);

		// Token: 0x0200004A RID: 74
		// (Invoke) Token: 0x06000191 RID: 401
		private delegate void YGNodeStyleSetPositionTypeDelegate(IntPtr node, YogaPositionType positionType);

		// Token: 0x0200004B RID: 75
		// (Invoke) Token: 0x06000193 RID: 403
		private delegate YogaPositionType YGNodeStyleGetPositionTypeDelegate(IntPtr node);

		// Token: 0x0200004C RID: 76
		// (Invoke) Token: 0x06000195 RID: 405
		private delegate void YGNodeStyleSetFlexWrapDelegate(IntPtr node, YogaWrap flexWrap);

		// Token: 0x0200004D RID: 77
		// (Invoke) Token: 0x06000197 RID: 407
		private delegate YogaWrap YGNodeStyleGetFlexWrapDelegate(IntPtr node);

		// Token: 0x0200004E RID: 78
		// (Invoke) Token: 0x06000199 RID: 409
		private delegate void YGNodeStyleSetOverflowDelegate(IntPtr node, YogaOverflow flexWrap);

		// Token: 0x0200004F RID: 79
		// (Invoke) Token: 0x0600019B RID: 411
		private delegate YogaOverflow YGNodeStyleGetOverflowDelegate(IntPtr node);

		// Token: 0x02000050 RID: 80
		// (Invoke) Token: 0x0600019D RID: 413
		private delegate void YGNodeStyleSetDisplayDelegate(IntPtr node, YogaDisplay display);

		// Token: 0x02000051 RID: 81
		// (Invoke) Token: 0x0600019F RID: 415
		private delegate YogaDisplay YGNodeStyleGetDisplayDelegate(IntPtr node);

		// Token: 0x02000052 RID: 82
		// (Invoke) Token: 0x060001A1 RID: 417
		private delegate void YGNodeStyleSetFlexDelegate(IntPtr node, float flex);

		// Token: 0x02000053 RID: 83
		// (Invoke) Token: 0x060001A3 RID: 419
		private delegate void YGNodeStyleSetFlexGrowDelegate(IntPtr node, float flexGrow);

		// Token: 0x02000054 RID: 84
		// (Invoke) Token: 0x060001A5 RID: 421
		private delegate float YGNodeStyleGetFlexGrowDelegate(IntPtr node);

		// Token: 0x02000055 RID: 85
		// (Invoke) Token: 0x060001A7 RID: 423
		private delegate void YGNodeStyleSetFlexShrinkDelegate(IntPtr node, float flexShrink);

		// Token: 0x02000056 RID: 86
		// (Invoke) Token: 0x060001A9 RID: 425
		private delegate float YGNodeStyleGetFlexShrinkDelegate(IntPtr node);

		// Token: 0x02000057 RID: 87
		// (Invoke) Token: 0x060001AB RID: 427
		private delegate void YGNodeStyleSetFlexBasisDelegate(IntPtr node, float flexBasis);

		// Token: 0x02000058 RID: 88
		// (Invoke) Token: 0x060001AD RID: 429
		private delegate void YGNodeStyleSetFlexBasisPercentDelegate(IntPtr node, float flexBasis);

		// Token: 0x02000059 RID: 89
		// (Invoke) Token: 0x060001AF RID: 431
		private delegate void YGNodeStyleSetFlexBasisAutoDelegate(IntPtr node);

		// Token: 0x0200005A RID: 90
		// (Invoke) Token: 0x060001B1 RID: 433
		private delegate float YGNodeGetComputedFlexBasisDelegate(IntPtr node);

		// Token: 0x0200005B RID: 91
		// (Invoke) Token: 0x060001B3 RID: 435
		private delegate void YGNodeStyleSetWidthDelegate(IntPtr node, float width);

		// Token: 0x0200005C RID: 92
		// (Invoke) Token: 0x060001B5 RID: 437
		private delegate void YGNodeStyleSetWidthPercentDelegate(IntPtr node, float width);

		// Token: 0x0200005D RID: 93
		// (Invoke) Token: 0x060001B7 RID: 439
		private delegate void YGNodeStyleSetWidthAutoDelegate(IntPtr node);

		// Token: 0x0200005E RID: 94
		// (Invoke) Token: 0x060001B9 RID: 441
		private delegate void YGNodeStyleSetHeightDelegate(IntPtr node, float height);

		// Token: 0x0200005F RID: 95
		// (Invoke) Token: 0x060001BB RID: 443
		private delegate void YGNodeStyleSetHeightPercentDelegate(IntPtr node, float height);

		// Token: 0x02000060 RID: 96
		// (Invoke) Token: 0x060001BD RID: 445
		private delegate void YGNodeStyleSetHeightAutoDelegate(IntPtr node);

		// Token: 0x02000061 RID: 97
		// (Invoke) Token: 0x060001BF RID: 447
		private delegate void YGNodeStyleSetMinWidthDelegate(IntPtr node, float minWidth);

		// Token: 0x02000062 RID: 98
		// (Invoke) Token: 0x060001C1 RID: 449
		private delegate void YGNodeStyleSetMinWidthPercentDelegate(IntPtr node, float minWidth);

		// Token: 0x02000063 RID: 99
		// (Invoke) Token: 0x060001C3 RID: 451
		private delegate void YGNodeStyleSetMinHeightDelegate(IntPtr node, float minHeight);

		// Token: 0x02000064 RID: 100
		// (Invoke) Token: 0x060001C5 RID: 453
		private delegate void YGNodeStyleSetMinHeightPercentDelegate(IntPtr node, float minHeight);

		// Token: 0x02000065 RID: 101
		// (Invoke) Token: 0x060001C7 RID: 455
		private delegate void YGNodeStyleSetMaxWidthDelegate(IntPtr node, float maxWidth);

		// Token: 0x02000066 RID: 102
		// (Invoke) Token: 0x060001C9 RID: 457
		private delegate void YGNodeStyleSetMaxWidthPercentDelegate(IntPtr node, float maxWidth);

		// Token: 0x02000067 RID: 103
		// (Invoke) Token: 0x060001CB RID: 459
		private delegate void YGNodeStyleSetMaxHeightDelegate(IntPtr node, float maxHeight);

		// Token: 0x02000068 RID: 104
		// (Invoke) Token: 0x060001CD RID: 461
		private delegate void YGNodeStyleSetMaxHeightPercentDelegate(IntPtr node, float maxHeight);

		// Token: 0x02000069 RID: 105
		// (Invoke) Token: 0x060001CF RID: 463
		private delegate void YGNodeStyleSetAspectRatioDelegate(IntPtr node, float aspectRatio);

		// Token: 0x0200006A RID: 106
		// (Invoke) Token: 0x060001D1 RID: 465
		private delegate float YGNodeStyleGetAspectRatioDelegate(IntPtr node);

		// Token: 0x0200006B RID: 107
		// (Invoke) Token: 0x060001D3 RID: 467
		private delegate void YGNodeStyleSetPositionDelegate(IntPtr node, YogaEdge edge, float position);

		// Token: 0x0200006C RID: 108
		// (Invoke) Token: 0x060001D5 RID: 469
		private delegate void YGNodeStyleSetPositionPercentDelegate(IntPtr node, YogaEdge edge, float position);

		// Token: 0x0200006D RID: 109
		// (Invoke) Token: 0x060001D7 RID: 471
		private delegate void YGNodeStyleSetMarginDelegate(IntPtr node, YogaEdge edge, float margin);

		// Token: 0x0200006E RID: 110
		// (Invoke) Token: 0x060001D9 RID: 473
		private delegate void YGNodeStyleSetMarginPercentDelegate(IntPtr node, YogaEdge edge, float margin);

		// Token: 0x0200006F RID: 111
		// (Invoke) Token: 0x060001DB RID: 475
		private delegate void YGNodeStyleSetMarginAutoDelegate(IntPtr node, YogaEdge edge);

		// Token: 0x02000070 RID: 112
		// (Invoke) Token: 0x060001DD RID: 477
		private delegate void YGNodeStyleSetPaddingDelegate(IntPtr node, YogaEdge edge, float padding);

		// Token: 0x02000071 RID: 113
		// (Invoke) Token: 0x060001DF RID: 479
		private delegate void YGNodeStyleSetPaddingPercentDelegate(IntPtr node, YogaEdge edge, float padding);

		// Token: 0x02000072 RID: 114
		// (Invoke) Token: 0x060001E1 RID: 481
		private delegate void YGNodeStyleSetBorderDelegate(IntPtr node, YogaEdge edge, float border);

		// Token: 0x02000073 RID: 115
		// (Invoke) Token: 0x060001E3 RID: 483
		private delegate float YGNodeStyleGetBorderDelegate(IntPtr node, YogaEdge edge);

		// Token: 0x02000074 RID: 116
		// (Invoke) Token: 0x060001E5 RID: 485
		private delegate float YGNodeLayoutGetLeftDelegate(IntPtr node);

		// Token: 0x02000075 RID: 117
		// (Invoke) Token: 0x060001E7 RID: 487
		private delegate float YGNodeLayoutGetTopDelegate(IntPtr node);

		// Token: 0x02000076 RID: 118
		// (Invoke) Token: 0x060001E9 RID: 489
		private delegate float YGNodeLayoutGetRightDelegate(IntPtr node);

		// Token: 0x02000077 RID: 119
		// (Invoke) Token: 0x060001EB RID: 491
		private delegate float YGNodeLayoutGetBottomDelegate(IntPtr node);

		// Token: 0x02000078 RID: 120
		// (Invoke) Token: 0x060001ED RID: 493
		private delegate float YGNodeLayoutGetWidthDelegate(IntPtr node);

		// Token: 0x02000079 RID: 121
		// (Invoke) Token: 0x060001EF RID: 495
		private delegate float YGNodeLayoutGetHeightDelegate(IntPtr node);

		// Token: 0x0200007A RID: 122
		// (Invoke) Token: 0x060001F1 RID: 497
		private delegate float YGNodeLayoutGetMarginDelegate(IntPtr node, YogaEdge edge);

		// Token: 0x0200007B RID: 123
		// (Invoke) Token: 0x060001F3 RID: 499
		private delegate float YGNodeLayoutGetPaddingDelegate(IntPtr node, YogaEdge edge);

		// Token: 0x0200007C RID: 124
		// (Invoke) Token: 0x060001F5 RID: 501
		private delegate YogaDirection YGNodeLayoutGetDirectionDelegate(IntPtr node);
	}
}
