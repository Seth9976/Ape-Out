using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UI
{
	// Token: 0x02000027 RID: 39
	public static class LayoutUtility : Object
	{
		// Token: 0x060004D0 RID: 1232 RVA: 0x00019538 File Offset: 0x00017738
		// Note: this type is marked as 'beforefieldinit'.
		static LayoutUtility()
		{
			Il2CppClassPointerStore<LayoutUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "LayoutUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LayoutUtility>.NativeClassPtr);
			LayoutUtility.NativeMethodInfoPtr_GetMinSize_Public_Static_Single_RectTransform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility>.NativeClassPtr, 100664081);
			LayoutUtility.NativeMethodInfoPtr_GetPreferredSize_Public_Static_Single_RectTransform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility>.NativeClassPtr, 100664082);
			LayoutUtility.NativeMethodInfoPtr_GetFlexibleSize_Public_Static_Single_RectTransform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility>.NativeClassPtr, 100664083);
			LayoutUtility.NativeMethodInfoPtr_GetMinWidth_Public_Static_Single_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility>.NativeClassPtr, 100664084);
			LayoutUtility.NativeMethodInfoPtr_GetPreferredWidth_Public_Static_Single_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility>.NativeClassPtr, 100664085);
			LayoutUtility.NativeMethodInfoPtr_GetFlexibleWidth_Public_Static_Single_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility>.NativeClassPtr, 100664086);
			LayoutUtility.NativeMethodInfoPtr_GetMinHeight_Public_Static_Single_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility>.NativeClassPtr, 100664087);
			LayoutUtility.NativeMethodInfoPtr_GetPreferredHeight_Public_Static_Single_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility>.NativeClassPtr, 100664088);
			LayoutUtility.NativeMethodInfoPtr_GetFlexibleHeight_Public_Static_Single_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility>.NativeClassPtr, 100664089);
			LayoutUtility.NativeMethodInfoPtr_GetLayoutProperty_Public_Static_Single_RectTransform_Func_2_ILayoutElement_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility>.NativeClassPtr, 100664090);
			LayoutUtility.NativeMethodInfoPtr_GetLayoutProperty_Public_Static_Single_RectTransform_Func_2_ILayoutElement_Single_Single_byref_ILayoutElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility>.NativeClassPtr, 100664091);
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00019644 File Offset: 0x00017844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 524744, XrefRangeEnd = 524746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetMinSize(RectTransform rect, int axis)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.NativeMethodInfoPtr_GetMinSize_Public_Static_Single_RectTransform_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x00019694 File Offset: 0x00017894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 524746, XrefRangeEnd = 524748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetPreferredSize(RectTransform rect, int axis)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.NativeMethodInfoPtr_GetPreferredSize_Public_Static_Single_RectTransform_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x000196E4 File Offset: 0x000178E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 524748, XrefRangeEnd = 524750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetFlexibleSize(RectTransform rect, int axis)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.NativeMethodInfoPtr_GetFlexibleSize_Public_Static_Single_RectTransform_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00019734 File Offset: 0x00017934
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 524764, RefRangeEnd = 524769, XrefRangeStart = 524750, XrefRangeEnd = 524764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetMinWidth(RectTransform rect)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.NativeMethodInfoPtr_GetMinWidth_Public_Static_Single_RectTransform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x00019778 File Offset: 0x00017978
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 524794, RefRangeEnd = 524801, XrefRangeStart = 524769, XrefRangeEnd = 524794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetPreferredWidth(RectTransform rect)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.NativeMethodInfoPtr_GetPreferredWidth_Public_Static_Single_RectTransform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x000197BC File Offset: 0x000179BC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 524815, RefRangeEnd = 524820, XrefRangeStart = 524801, XrefRangeEnd = 524815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetFlexibleWidth(RectTransform rect)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.NativeMethodInfoPtr_GetFlexibleWidth_Public_Static_Single_RectTransform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x00019800 File Offset: 0x00017A00
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 524834, RefRangeEnd = 524839, XrefRangeStart = 524820, XrefRangeEnd = 524834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetMinHeight(RectTransform rect)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.NativeMethodInfoPtr_GetMinHeight_Public_Static_Single_RectTransform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00019844 File Offset: 0x00017A44
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 524864, RefRangeEnd = 524870, XrefRangeStart = 524839, XrefRangeEnd = 524864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetPreferredHeight(RectTransform rect)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.NativeMethodInfoPtr_GetPreferredHeight_Public_Static_Single_RectTransform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00019888 File Offset: 0x00017A88
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 524884, RefRangeEnd = 524889, XrefRangeStart = 524870, XrefRangeEnd = 524884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetFlexibleHeight(RectTransform rect)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.NativeMethodInfoPtr_GetFlexibleHeight_Public_Static_Single_RectTransform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x000198CC File Offset: 0x00017ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 524889, XrefRangeEnd = 524890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, float> property, float defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(property);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.NativeMethodInfoPtr_GetLayoutProperty_Public_Static_Single_RectTransform_Func_2_ILayoutElement_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00019930 File Offset: 0x00017B30
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 524938, RefRangeEnd = 524947, XrefRangeStart = 524890, XrefRangeEnd = 524938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, float> property, float defaultValue, out ILayoutElement source)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(property);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.NativeMethodInfoPtr_GetLayoutProperty_Public_Static_Single_RectTransform_Func_2_ILayoutElement_Single_Single_byref_ILayoutElement_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			source = ((intPtr4 == 0) ? null : new ILayoutElement(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00003A47 File Offset: 0x00001C47
		public LayoutUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003B4 RID: 948
		private static readonly IntPtr NativeMethodInfoPtr_GetMinSize_Public_Static_Single_RectTransform_Int32_0;

		// Token: 0x040003B5 RID: 949
		private static readonly IntPtr NativeMethodInfoPtr_GetPreferredSize_Public_Static_Single_RectTransform_Int32_0;

		// Token: 0x040003B6 RID: 950
		private static readonly IntPtr NativeMethodInfoPtr_GetFlexibleSize_Public_Static_Single_RectTransform_Int32_0;

		// Token: 0x040003B7 RID: 951
		private static readonly IntPtr NativeMethodInfoPtr_GetMinWidth_Public_Static_Single_RectTransform_0;

		// Token: 0x040003B8 RID: 952
		private static readonly IntPtr NativeMethodInfoPtr_GetPreferredWidth_Public_Static_Single_RectTransform_0;

		// Token: 0x040003B9 RID: 953
		private static readonly IntPtr NativeMethodInfoPtr_GetFlexibleWidth_Public_Static_Single_RectTransform_0;

		// Token: 0x040003BA RID: 954
		private static readonly IntPtr NativeMethodInfoPtr_GetMinHeight_Public_Static_Single_RectTransform_0;

		// Token: 0x040003BB RID: 955
		private static readonly IntPtr NativeMethodInfoPtr_GetPreferredHeight_Public_Static_Single_RectTransform_0;

		// Token: 0x040003BC RID: 956
		private static readonly IntPtr NativeMethodInfoPtr_GetFlexibleHeight_Public_Static_Single_RectTransform_0;

		// Token: 0x040003BD RID: 957
		private static readonly IntPtr NativeMethodInfoPtr_GetLayoutProperty_Public_Static_Single_RectTransform_Func_2_ILayoutElement_Single_Single_0;

		// Token: 0x040003BE RID: 958
		private static readonly IntPtr NativeMethodInfoPtr_GetLayoutProperty_Public_Static_Single_RectTransform_Func_2_ILayoutElement_Single_Single_byref_ILayoutElement_0;

		// Token: 0x0200009E RID: 158
		[ObfuscatedName("UnityEngine.UI.LayoutUtility+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000BF6 RID: 3062 RVA: 0x000342F4 File Offset: 0x000324F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LayoutUtility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr);
				LayoutUtility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, "<>9");
				LayoutUtility.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, "<>9__3_0");
				LayoutUtility.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, "<>9__4_0");
				LayoutUtility.__c.NativeFieldInfoPtr___9__4_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, "<>9__4_1");
				LayoutUtility.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, "<>9__5_0");
				LayoutUtility.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, "<>9__6_0");
				LayoutUtility.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, "<>9__7_0");
				LayoutUtility.__c.NativeFieldInfoPtr___9__7_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, "<>9__7_1");
				LayoutUtility.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, "<>9__8_0");
				LayoutUtility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, 100664093);
				LayoutUtility.__c.NativeMethodInfoPtr__GetMinWidth_b__3_0_Internal_Single_ILayoutElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, 100664094);
				LayoutUtility.__c.NativeMethodInfoPtr__GetPreferredWidth_b__4_0_Internal_Single_ILayoutElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, 100664095);
				LayoutUtility.__c.NativeMethodInfoPtr__GetPreferredWidth_b__4_1_Internal_Single_ILayoutElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, 100664096);
				LayoutUtility.__c.NativeMethodInfoPtr__GetFlexibleWidth_b__5_0_Internal_Single_ILayoutElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, 100664097);
				LayoutUtility.__c.NativeMethodInfoPtr__GetMinHeight_b__6_0_Internal_Single_ILayoutElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, 100664098);
				LayoutUtility.__c.NativeMethodInfoPtr__GetPreferredHeight_b__7_0_Internal_Single_ILayoutElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, 100664099);
				LayoutUtility.__c.NativeMethodInfoPtr__GetPreferredHeight_b__7_1_Internal_Single_ILayoutElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, 100664100);
				LayoutUtility.__c.NativeMethodInfoPtr__GetFlexibleHeight_b__8_0_Internal_Single_ILayoutElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, 100664101);
			}

			// Token: 0x06000BF7 RID: 3063 RVA: 0x00034488 File Offset: 0x00032688
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000BF8 RID: 3064 RVA: 0x000344C4 File Offset: 0x000326C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 524712, XrefRangeEnd = 524716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _GetMinWidth_b__3_0(ILayoutElement e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.__c.NativeMethodInfoPtr__GetMinWidth_b__3_0_Internal_Single_ILayoutElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000BF9 RID: 3065 RVA: 0x00034514 File Offset: 0x00032714
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 524716, XrefRangeEnd = 524720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _GetPreferredWidth_b__4_0(ILayoutElement e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.__c.NativeMethodInfoPtr__GetPreferredWidth_b__4_0_Internal_Single_ILayoutElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000BFA RID: 3066 RVA: 0x00034564 File Offset: 0x00032764
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 524720, XrefRangeEnd = 524724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _GetPreferredWidth_b__4_1(ILayoutElement e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.__c.NativeMethodInfoPtr__GetPreferredWidth_b__4_1_Internal_Single_ILayoutElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000BFB RID: 3067 RVA: 0x000345B4 File Offset: 0x000327B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 524724, XrefRangeEnd = 524728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _GetFlexibleWidth_b__5_0(ILayoutElement e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.__c.NativeMethodInfoPtr__GetFlexibleWidth_b__5_0_Internal_Single_ILayoutElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000BFC RID: 3068 RVA: 0x00034604 File Offset: 0x00032804
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 524728, XrefRangeEnd = 524732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _GetMinHeight_b__6_0(ILayoutElement e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.__c.NativeMethodInfoPtr__GetMinHeight_b__6_0_Internal_Single_ILayoutElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000BFD RID: 3069 RVA: 0x00034654 File Offset: 0x00032854
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 524732, XrefRangeEnd = 524736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _GetPreferredHeight_b__7_0(ILayoutElement e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.__c.NativeMethodInfoPtr__GetPreferredHeight_b__7_0_Internal_Single_ILayoutElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000BFE RID: 3070 RVA: 0x000346A4 File Offset: 0x000328A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 524736, XrefRangeEnd = 524740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _GetPreferredHeight_b__7_1(ILayoutElement e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.__c.NativeMethodInfoPtr__GetPreferredHeight_b__7_1_Internal_Single_ILayoutElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000BFF RID: 3071 RVA: 0x000346F4 File Offset: 0x000328F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 524740, XrefRangeEnd = 524744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _GetFlexibleHeight_b__8_0(ILayoutElement e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.__c.NativeMethodInfoPtr__GetFlexibleHeight_b__8_0_Internal_Single_ILayoutElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000C00 RID: 3072 RVA: 0x00006702 File Offset: 0x00004902
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003FD RID: 1021
			// (get) Token: 0x06000C01 RID: 3073 RVA: 0x00034744 File Offset: 0x00032944
			// (set) Token: 0x06000C02 RID: 3074 RVA: 0x0000670B File Offset: 0x0000490B
			public unsafe static LayoutUtility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LayoutUtility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LayoutUtility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LayoutUtility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003FE RID: 1022
			// (get) Token: 0x06000C03 RID: 3075 RVA: 0x0003476C File Offset: 0x0003296C
			// (set) Token: 0x06000C04 RID: 3076 RVA: 0x0000671D File Offset: 0x0000491D
			public unsafe static Func<ILayoutElement, float> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LayoutUtility.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ILayoutElement, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LayoutUtility.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003FF RID: 1023
			// (get) Token: 0x06000C05 RID: 3077 RVA: 0x00034794 File Offset: 0x00032994
			// (set) Token: 0x06000C06 RID: 3078 RVA: 0x0000672F File Offset: 0x0000492F
			public unsafe static Func<ILayoutElement, float> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LayoutUtility.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ILayoutElement, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LayoutUtility.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000400 RID: 1024
			// (get) Token: 0x06000C07 RID: 3079 RVA: 0x000347BC File Offset: 0x000329BC
			// (set) Token: 0x06000C08 RID: 3080 RVA: 0x00006741 File Offset: 0x00004941
			public unsafe static Func<ILayoutElement, float> __9__4_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LayoutUtility.__c.NativeFieldInfoPtr___9__4_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ILayoutElement, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LayoutUtility.__c.NativeFieldInfoPtr___9__4_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000401 RID: 1025
			// (get) Token: 0x06000C09 RID: 3081 RVA: 0x000347E4 File Offset: 0x000329E4
			// (set) Token: 0x06000C0A RID: 3082 RVA: 0x00006753 File Offset: 0x00004953
			public unsafe static Func<ILayoutElement, float> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LayoutUtility.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ILayoutElement, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LayoutUtility.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000402 RID: 1026
			// (get) Token: 0x06000C0B RID: 3083 RVA: 0x0003480C File Offset: 0x00032A0C
			// (set) Token: 0x06000C0C RID: 3084 RVA: 0x00006765 File Offset: 0x00004965
			public unsafe static Func<ILayoutElement, float> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LayoutUtility.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ILayoutElement, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LayoutUtility.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000403 RID: 1027
			// (get) Token: 0x06000C0D RID: 3085 RVA: 0x00034834 File Offset: 0x00032A34
			// (set) Token: 0x06000C0E RID: 3086 RVA: 0x00006777 File Offset: 0x00004977
			public unsafe static Func<ILayoutElement, float> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LayoutUtility.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ILayoutElement, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LayoutUtility.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000404 RID: 1028
			// (get) Token: 0x06000C0F RID: 3087 RVA: 0x0003485C File Offset: 0x00032A5C
			// (set) Token: 0x06000C10 RID: 3088 RVA: 0x00006789 File Offset: 0x00004989
			public unsafe static Func<ILayoutElement, float> __9__7_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LayoutUtility.__c.NativeFieldInfoPtr___9__7_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ILayoutElement, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LayoutUtility.__c.NativeFieldInfoPtr___9__7_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000405 RID: 1029
			// (get) Token: 0x06000C11 RID: 3089 RVA: 0x00034884 File Offset: 0x00032A84
			// (set) Token: 0x06000C12 RID: 3090 RVA: 0x0000679B File Offset: 0x0000499B
			public unsafe static Func<ILayoutElement, float> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LayoutUtility.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ILayoutElement, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LayoutUtility.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000948 RID: 2376
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000949 RID: 2377
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x0400094A RID: 2378
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x0400094B RID: 2379
			private static readonly IntPtr NativeFieldInfoPtr___9__4_1;

			// Token: 0x0400094C RID: 2380
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x0400094D RID: 2381
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x0400094E RID: 2382
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x0400094F RID: 2383
			private static readonly IntPtr NativeFieldInfoPtr___9__7_1;

			// Token: 0x04000950 RID: 2384
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x04000951 RID: 2385
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000952 RID: 2386
			private static readonly IntPtr NativeMethodInfoPtr__GetMinWidth_b__3_0_Internal_Single_ILayoutElement_0;

			// Token: 0x04000953 RID: 2387
			private static readonly IntPtr NativeMethodInfoPtr__GetPreferredWidth_b__4_0_Internal_Single_ILayoutElement_0;

			// Token: 0x04000954 RID: 2388
			private static readonly IntPtr NativeMethodInfoPtr__GetPreferredWidth_b__4_1_Internal_Single_ILayoutElement_0;

			// Token: 0x04000955 RID: 2389
			private static readonly IntPtr NativeMethodInfoPtr__GetFlexibleWidth_b__5_0_Internal_Single_ILayoutElement_0;

			// Token: 0x04000956 RID: 2390
			private static readonly IntPtr NativeMethodInfoPtr__GetMinHeight_b__6_0_Internal_Single_ILayoutElement_0;

			// Token: 0x04000957 RID: 2391
			private static readonly IntPtr NativeMethodInfoPtr__GetPreferredHeight_b__7_0_Internal_Single_ILayoutElement_0;

			// Token: 0x04000958 RID: 2392
			private static readonly IntPtr NativeMethodInfoPtr__GetPreferredHeight_b__7_1_Internal_Single_ILayoutElement_0;

			// Token: 0x04000959 RID: 2393
			private static readonly IntPtr NativeMethodInfoPtr__GetFlexibleHeight_b__8_0_Internal_Single_ILayoutElement_0;
		}
	}
}
