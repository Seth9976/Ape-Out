using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppRewired.ComponentControls.Data
{
	// Token: 0x02000042 RID: 66
	[Serializable]
	public class CustomControllerElementTargetSetForFloat : CustomControllerElementTargetSet
	{
		// Token: 0x06000510 RID: 1296 RVA: 0x0004138C File Offset: 0x0003F58C
		// Note: this type is marked as 'beforefieldinit'.
		static CustomControllerElementTargetSetForFloat()
		{
			Il2CppClassPointerStore<CustomControllerElementTargetSetForFloat>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.ComponentControls.Data", "CustomControllerElementTargetSetForFloat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomControllerElementTargetSetForFloat>.NativeClassPtr);
			CustomControllerElementTargetSetForFloat.NativeFieldInfoPtr__splitValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerElementTargetSetForFloat>.NativeClassPtr, "_splitValue");
			CustomControllerElementTargetSetForFloat.NativeFieldInfoPtr__target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerElementTargetSetForFloat>.NativeClassPtr, "_target");
			CustomControllerElementTargetSetForFloat.NativeFieldInfoPtr__positiveTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerElementTargetSetForFloat>.NativeClassPtr, "_positiveTarget");
			CustomControllerElementTargetSetForFloat.NativeFieldInfoPtr__negativeTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerElementTargetSetForFloat>.NativeClassPtr, "_negativeTarget");
			CustomControllerElementTargetSetForFloat.NativeMethodInfoPtr_get_splitValue_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerElementTargetSetForFloat>.NativeClassPtr, 100664171);
			CustomControllerElementTargetSetForFloat.NativeMethodInfoPtr_set_splitValue_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerElementTargetSetForFloat>.NativeClassPtr, 100664172);
			CustomControllerElementTargetSetForFloat.NativeMethodInfoPtr_get_target_Public_get_CustomControllerElementTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerElementTargetSetForFloat>.NativeClassPtr, 100664173);
			CustomControllerElementTargetSetForFloat.NativeMethodInfoPtr_get_positiveTarget_Public_get_CustomControllerElementTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerElementTargetSetForFloat>.NativeClassPtr, 100664174);
			CustomControllerElementTargetSetForFloat.NativeMethodInfoPtr_get_negativeTarget_Public_get_CustomControllerElementTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerElementTargetSetForFloat>.NativeClassPtr, 100664175);
			CustomControllerElementTargetSetForFloat.NativeMethodInfoPtr_get_targetCount_Internal_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerElementTargetSetForFloat>.NativeClassPtr, 100664176);
			CustomControllerElementTargetSetForFloat.NativeMethodInfoPtr_get_Item_Internal_Virtual_get_CustomControllerElementTarget_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerElementTargetSetForFloat>.NativeClassPtr, 100664177);
			CustomControllerElementTargetSetForFloat.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerElementTargetSetForFloat>.NativeClassPtr, 100664178);
			CustomControllerElementTargetSetForFloat.NativeMethodInfoPtr__ctor_Internal_Void_CustomControllerElementTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerElementTargetSetForFloat>.NativeClassPtr, 100664179);
			CustomControllerElementTargetSetForFloat.NativeMethodInfoPtr__ctor_Internal_Void_CustomControllerElementTarget_CustomControllerElementTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerElementTargetSetForFloat>.NativeClassPtr, 100664180);
			CustomControllerElementTargetSetForFloat.NativeMethodInfoPtr_ClearElementCaches_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerElementTargetSetForFloat>.NativeClassPtr, 100664181);
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000511 RID: 1297 RVA: 0x000414E8 File Offset: 0x0003F6E8
		// (set) Token: 0x06000512 RID: 1298 RVA: 0x00041524 File Offset: 0x0003F724
		public unsafe bool splitValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerElementTargetSetForFloat.NativeMethodInfoPtr_get_splitValue_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerElementTargetSetForFloat.NativeMethodInfoPtr_set_splitValue_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000513 RID: 1299 RVA: 0x00041564 File Offset: 0x0003F764
		public unsafe CustomControllerElementTarget target
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerElementTargetSetForFloat.NativeMethodInfoPtr_get_target_Public_get_CustomControllerElementTarget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomControllerElementTarget>(intPtr3) : null;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000514 RID: 1300 RVA: 0x000415A4 File Offset: 0x0003F7A4
		public unsafe CustomControllerElementTarget positiveTarget
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerElementTargetSetForFloat.NativeMethodInfoPtr_get_positiveTarget_Public_get_CustomControllerElementTarget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomControllerElementTarget>(intPtr3) : null;
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000515 RID: 1301 RVA: 0x000415E4 File Offset: 0x0003F7E4
		public unsafe CustomControllerElementTarget negativeTarget
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerElementTargetSetForFloat.NativeMethodInfoPtr_get_negativeTarget_Public_get_CustomControllerElementTarget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomControllerElementTarget>(intPtr3) : null;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x00041624 File Offset: 0x0003F824
		public unsafe override int targetCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomControllerElementTargetSetForFloat.NativeMethodInfoPtr_get_targetCount_Internal_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700019B RID: 411
		public unsafe override CustomControllerElementTarget this[int index]
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomControllerElementTargetSetForFloat.NativeMethodInfoPtr_get_Item_Internal_Virtual_get_CustomControllerElementTarget_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomControllerElementTarget>(intPtr3) : null;
				}
			}
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x000416C4 File Offset: 0x0003F8C4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 245936, RefRangeEnd = 245942, XrefRangeStart = 245919, XrefRangeEnd = 245936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomControllerElementTargetSetForFloat()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomControllerElementTargetSetForFloat>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerElementTargetSetForFloat.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00041700 File Offset: 0x0003F900
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 245959, RefRangeEnd = 245960, XrefRangeStart = 245942, XrefRangeEnd = 245959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomControllerElementTargetSetForFloat(CustomControllerElementTarget target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomControllerElementTargetSetForFloat>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerElementTargetSetForFloat.NativeMethodInfoPtr__ctor_Internal_Void_CustomControllerElementTarget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x0004174C File Offset: 0x0003F94C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245960, XrefRangeEnd = 245977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomControllerElementTargetSetForFloat(CustomControllerElementTarget positiveTarget, CustomControllerElementTarget negativeTarget)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomControllerElementTargetSetForFloat>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(positiveTarget);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(negativeTarget);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerElementTargetSetForFloat.NativeMethodInfoPtr__ctor_Internal_Void_CustomControllerElementTarget_CustomControllerElementTarget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x000417AC File Offset: 0x0003F9AC
		[CallerCount(0)]
		public unsafe override void ClearElementCaches()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomControllerElementTargetSetForFloat.NativeMethodInfoPtr_ClearElementCaches_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x0000392E File Offset: 0x00001B2E
		public CustomControllerElementTargetSetForFloat(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x000417E8 File Offset: 0x0003F9E8
		// (set) Token: 0x0600051E RID: 1310 RVA: 0x00003937 File Offset: 0x00001B37
		public unsafe bool _splitValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerElementTargetSetForFloat.NativeFieldInfoPtr__splitValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerElementTargetSetForFloat.NativeFieldInfoPtr__splitValue)) = value;
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x0600051F RID: 1311 RVA: 0x00041810 File Offset: 0x0003FA10
		// (set) Token: 0x06000520 RID: 1312 RVA: 0x00003952 File Offset: 0x00001B52
		public unsafe CustomControllerElementTarget _target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerElementTargetSetForFloat.NativeFieldInfoPtr__target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomControllerElementTarget>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerElementTargetSetForFloat.NativeFieldInfoPtr__target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000521 RID: 1313 RVA: 0x00041840 File Offset: 0x0003FA40
		// (set) Token: 0x06000522 RID: 1314 RVA: 0x00003971 File Offset: 0x00001B71
		public unsafe CustomControllerElementTarget _positiveTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerElementTargetSetForFloat.NativeFieldInfoPtr__positiveTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomControllerElementTarget>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerElementTargetSetForFloat.NativeFieldInfoPtr__positiveTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000523 RID: 1315 RVA: 0x00041870 File Offset: 0x0003FA70
		// (set) Token: 0x06000524 RID: 1316 RVA: 0x00003990 File Offset: 0x00001B90
		public unsafe CustomControllerElementTarget _negativeTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerElementTargetSetForFloat.NativeFieldInfoPtr__negativeTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomControllerElementTarget>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerElementTargetSetForFloat.NativeFieldInfoPtr__negativeTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000447 RID: 1095
		private static readonly IntPtr NativeFieldInfoPtr__splitValue;

		// Token: 0x04000448 RID: 1096
		private static readonly IntPtr NativeFieldInfoPtr__target;

		// Token: 0x04000449 RID: 1097
		private static readonly IntPtr NativeFieldInfoPtr__positiveTarget;

		// Token: 0x0400044A RID: 1098
		private static readonly IntPtr NativeFieldInfoPtr__negativeTarget;

		// Token: 0x0400044B RID: 1099
		private static readonly IntPtr NativeMethodInfoPtr_get_splitValue_Public_get_Boolean_0;

		// Token: 0x0400044C RID: 1100
		private static readonly IntPtr NativeMethodInfoPtr_set_splitValue_Public_set_Void_Boolean_0;

		// Token: 0x0400044D RID: 1101
		private static readonly IntPtr NativeMethodInfoPtr_get_target_Public_get_CustomControllerElementTarget_0;

		// Token: 0x0400044E RID: 1102
		private static readonly IntPtr NativeMethodInfoPtr_get_positiveTarget_Public_get_CustomControllerElementTarget_0;

		// Token: 0x0400044F RID: 1103
		private static readonly IntPtr NativeMethodInfoPtr_get_negativeTarget_Public_get_CustomControllerElementTarget_0;

		// Token: 0x04000450 RID: 1104
		private static readonly IntPtr NativeMethodInfoPtr_get_targetCount_Internal_Virtual_get_Int32_0;

		// Token: 0x04000451 RID: 1105
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Internal_Virtual_get_CustomControllerElementTarget_Int32_0;

		// Token: 0x04000452 RID: 1106
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000453 RID: 1107
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CustomControllerElementTarget_0;

		// Token: 0x04000454 RID: 1108
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CustomControllerElementTarget_CustomControllerElementTarget_0;

		// Token: 0x04000455 RID: 1109
		private static readonly IntPtr NativeMethodInfoPtr_ClearElementCaches_Internal_Virtual_Void_0;
	}
}
