using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.ComponentControls.Data
{
	// Token: 0x0200003F RID: 63
	[Serializable]
	public class CustomControllerElementTarget : Object
	{
		// Token: 0x060004EA RID: 1258 RVA: 0x00040AD4 File Offset: 0x0003ECD4
		// Note: this type is marked as 'beforefieldinit'.
		static CustomControllerElementTarget()
		{
			Il2CppClassPointerStore<CustomControllerElementTarget>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.ComponentControls.Data", "CustomControllerElementTarget");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomControllerElementTarget>.NativeClassPtr);
			CustomControllerElementTarget.NativeFieldInfoPtr__element = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerElementTarget>.NativeClassPtr, "_element");
			CustomControllerElementTarget.NativeFieldInfoPtr__valueRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerElementTarget>.NativeClassPtr, "_valueRange");
			CustomControllerElementTarget.NativeFieldInfoPtr__valueContribution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerElementTarget>.NativeClassPtr, "_valueContribution");
			CustomControllerElementTarget.NativeFieldInfoPtr__invert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerElementTarget>.NativeClassPtr, "_invert");
			CustomControllerElementTarget.NativeMethodInfoPtr_get_element_Public_get_CustomControllerElementSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerElementTarget>.NativeClassPtr, 100664151);
			CustomControllerElementTarget.NativeMethodInfoPtr_get_valueContribution_Public_get_Pole_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerElementTarget>.NativeClassPtr, 100664152);
			CustomControllerElementTarget.NativeMethodInfoPtr_set_valueContribution_Public_set_Void_Pole_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerElementTarget>.NativeClassPtr, 100664153);
			CustomControllerElementTarget.NativeMethodInfoPtr_get_valueRange_Internal_get_ValueRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerElementTarget>.NativeClassPtr, 100664154);
			CustomControllerElementTarget.NativeMethodInfoPtr_set_valueRange_Internal_set_Void_ValueRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerElementTarget>.NativeClassPtr, 100664155);
			CustomControllerElementTarget.NativeMethodInfoPtr_get_invert_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerElementTarget>.NativeClassPtr, 100664156);
			CustomControllerElementTarget.NativeMethodInfoPtr_set_invert_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerElementTarget>.NativeClassPtr, 100664157);
			CustomControllerElementTarget.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerElementTarget>.NativeClassPtr, 100664158);
			CustomControllerElementTarget.NativeMethodInfoPtr__ctor_Internal_Void_CustomControllerElementSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerElementTarget>.NativeClassPtr, 100664159);
			CustomControllerElementTarget.NativeMethodInfoPtr_ClearElementCaches_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerElementTarget>.NativeClassPtr, 100664160);
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060004EB RID: 1259 RVA: 0x00040C1C File Offset: 0x0003EE1C
		public unsafe CustomControllerElementSelector element
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerElementTarget.NativeMethodInfoPtr_get_element_Public_get_CustomControllerElementSelector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomControllerElementSelector>(intPtr3) : null;
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060004EC RID: 1260 RVA: 0x00040C5C File Offset: 0x0003EE5C
		// (set) Token: 0x060004ED RID: 1261 RVA: 0x00040C98 File Offset: 0x0003EE98
		public unsafe Pole valueContribution
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerElementTarget.NativeMethodInfoPtr_get_valueContribution_Public_get_Pole_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerElementTarget.NativeMethodInfoPtr_set_valueContribution_Public_set_Void_Pole_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060004EE RID: 1262 RVA: 0x00040CD8 File Offset: 0x0003EED8
		// (set) Token: 0x060004EF RID: 1263 RVA: 0x00040D14 File Offset: 0x0003EF14
		public unsafe CustomControllerElementTarget.ValueRange valueRange
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerElementTarget.NativeMethodInfoPtr_get_valueRange_Internal_get_ValueRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerElementTarget.NativeMethodInfoPtr_set_valueRange_Internal_set_Void_ValueRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060004F0 RID: 1264 RVA: 0x00040D54 File Offset: 0x0003EF54
		// (set) Token: 0x060004F1 RID: 1265 RVA: 0x00040D90 File Offset: 0x0003EF90
		public unsafe bool invert
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerElementTarget.NativeMethodInfoPtr_get_invert_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerElementTarget.NativeMethodInfoPtr_set_invert_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00040DD0 File Offset: 0x0003EFD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245884, XrefRangeEnd = 245887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomControllerElementTarget()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomControllerElementTarget>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerElementTarget.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00040E0C File Offset: 0x0003F00C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 245890, RefRangeEnd = 245902, XrefRangeStart = 245887, XrefRangeEnd = 245890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomControllerElementTarget(CustomControllerElementSelector selector)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomControllerElementTarget>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selector);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerElementTarget.NativeMethodInfoPtr__ctor_Internal_Void_CustomControllerElementSelector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00040E58 File Offset: 0x0003F058
		[CallerCount(0)]
		public unsafe void ClearElementCaches()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerElementTarget.NativeMethodInfoPtr_ClearElementCaches_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00003876 File Offset: 0x00001A76
		public CustomControllerElementTarget(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060004F6 RID: 1270 RVA: 0x00040E8C File Offset: 0x0003F08C
		// (set) Token: 0x060004F7 RID: 1271 RVA: 0x0000387F File Offset: 0x00001A7F
		public unsafe CustomControllerElementSelector _element
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerElementTarget.NativeFieldInfoPtr__element);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomControllerElementSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerElementTarget.NativeFieldInfoPtr__element), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060004F8 RID: 1272 RVA: 0x00040EBC File Offset: 0x0003F0BC
		// (set) Token: 0x060004F9 RID: 1273 RVA: 0x0000389E File Offset: 0x00001A9E
		public unsafe CustomControllerElementTarget.ValueRange _valueRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerElementTarget.NativeFieldInfoPtr__valueRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerElementTarget.NativeFieldInfoPtr__valueRange)) = value;
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060004FA RID: 1274 RVA: 0x00040EE4 File Offset: 0x0003F0E4
		// (set) Token: 0x060004FB RID: 1275 RVA: 0x000038B9 File Offset: 0x00001AB9
		public unsafe Pole _valueContribution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerElementTarget.NativeFieldInfoPtr__valueContribution);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerElementTarget.NativeFieldInfoPtr__valueContribution)) = value;
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060004FC RID: 1276 RVA: 0x00040F0C File Offset: 0x0003F10C
		// (set) Token: 0x060004FD RID: 1277 RVA: 0x000038D4 File Offset: 0x00001AD4
		public unsafe bool _invert
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerElementTarget.NativeFieldInfoPtr__invert);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerElementTarget.NativeFieldInfoPtr__invert)) = value;
			}
		}

		// Token: 0x0400042D RID: 1069
		private static readonly IntPtr NativeFieldInfoPtr__element;

		// Token: 0x0400042E RID: 1070
		private static readonly IntPtr NativeFieldInfoPtr__valueRange;

		// Token: 0x0400042F RID: 1071
		private static readonly IntPtr NativeFieldInfoPtr__valueContribution;

		// Token: 0x04000430 RID: 1072
		private static readonly IntPtr NativeFieldInfoPtr__invert;

		// Token: 0x04000431 RID: 1073
		private static readonly IntPtr NativeMethodInfoPtr_get_element_Public_get_CustomControllerElementSelector_0;

		// Token: 0x04000432 RID: 1074
		private static readonly IntPtr NativeMethodInfoPtr_get_valueContribution_Public_get_Pole_0;

		// Token: 0x04000433 RID: 1075
		private static readonly IntPtr NativeMethodInfoPtr_set_valueContribution_Public_set_Void_Pole_0;

		// Token: 0x04000434 RID: 1076
		private static readonly IntPtr NativeMethodInfoPtr_get_valueRange_Internal_get_ValueRange_0;

		// Token: 0x04000435 RID: 1077
		private static readonly IntPtr NativeMethodInfoPtr_set_valueRange_Internal_set_Void_ValueRange_0;

		// Token: 0x04000436 RID: 1078
		private static readonly IntPtr NativeMethodInfoPtr_get_invert_Public_get_Boolean_0;

		// Token: 0x04000437 RID: 1079
		private static readonly IntPtr NativeMethodInfoPtr_set_invert_Public_set_Void_Boolean_0;

		// Token: 0x04000438 RID: 1080
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000439 RID: 1081
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CustomControllerElementSelector_0;

		// Token: 0x0400043A RID: 1082
		private static readonly IntPtr NativeMethodInfoPtr_ClearElementCaches_Internal_Void_0;

		// Token: 0x0200023C RID: 572
		[OriginalName("Rewired_Core.dll", "", "ValueRange")]
		public enum ValueRange
		{
			// Token: 0x04002FC7 RID: 12231
			Full,
			// Token: 0x04002FC8 RID: 12232
			Positive,
			// Token: 0x04002FC9 RID: 12233
			Negative
		}
	}
}
