using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppRewired.ComponentControls.Data
{
	// Token: 0x02000041 RID: 65
	[Serializable]
	public class CustomControllerElementTargetSetForBoolean : CustomControllerElementTargetSet
	{
		// Token: 0x06000504 RID: 1284 RVA: 0x000410CC File Offset: 0x0003F2CC
		// Note: this type is marked as 'beforefieldinit'.
		static CustomControllerElementTargetSetForBoolean()
		{
			Il2CppClassPointerStore<CustomControllerElementTargetSetForBoolean>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.ComponentControls.Data", "CustomControllerElementTargetSetForBoolean");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomControllerElementTargetSetForBoolean>.NativeClassPtr);
			CustomControllerElementTargetSetForBoolean.NativeFieldInfoPtr_ThZMnYXmzRIaAFXAwkoRLagiqkc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerElementTargetSetForBoolean>.NativeClassPtr, "ThZMnYXmzRIaAFXAwkoRLagiqkc");
			CustomControllerElementTargetSetForBoolean.NativeFieldInfoPtr__target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerElementTargetSetForBoolean>.NativeClassPtr, "_target");
			CustomControllerElementTargetSetForBoolean.NativeMethodInfoPtr_get_target_Public_get_CustomControllerElementTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerElementTargetSetForBoolean>.NativeClassPtr, 100664165);
			CustomControllerElementTargetSetForBoolean.NativeMethodInfoPtr_get_targetCount_Internal_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerElementTargetSetForBoolean>.NativeClassPtr, 100664166);
			CustomControllerElementTargetSetForBoolean.NativeMethodInfoPtr_get_Item_Internal_Virtual_get_CustomControllerElementTarget_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerElementTargetSetForBoolean>.NativeClassPtr, 100664167);
			CustomControllerElementTargetSetForBoolean.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerElementTargetSetForBoolean>.NativeClassPtr, 100664168);
			CustomControllerElementTargetSetForBoolean.NativeMethodInfoPtr__ctor_Internal_Void_CustomControllerElementTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerElementTargetSetForBoolean>.NativeClassPtr, 100664169);
			CustomControllerElementTargetSetForBoolean.NativeMethodInfoPtr_ClearElementCaches_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerElementTargetSetForBoolean>.NativeClassPtr, 100664170);
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000505 RID: 1285 RVA: 0x0004119C File Offset: 0x0003F39C
		public unsafe CustomControllerElementTarget target
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerElementTargetSetForBoolean.NativeMethodInfoPtr_get_target_Public_get_CustomControllerElementTarget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomControllerElementTarget>(intPtr3) : null;
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x000411DC File Offset: 0x0003F3DC
		public unsafe override int targetCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomControllerElementTargetSetForBoolean.NativeMethodInfoPtr_get_targetCount_Internal_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000191 RID: 401
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomControllerElementTargetSetForBoolean.NativeMethodInfoPtr_get_Item_Internal_Virtual_get_CustomControllerElementTarget_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomControllerElementTarget>(intPtr3) : null;
				}
			}
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x0004127C File Offset: 0x0003F47C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 245909, RefRangeEnd = 245912, XrefRangeStart = 245902, XrefRangeEnd = 245909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomControllerElementTargetSetForBoolean()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomControllerElementTargetSetForBoolean>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerElementTargetSetForBoolean.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x000412B8 File Offset: 0x0003F4B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245912, XrefRangeEnd = 245919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomControllerElementTargetSetForBoolean(CustomControllerElementTarget target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomControllerElementTargetSetForBoolean>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerElementTargetSetForBoolean.NativeMethodInfoPtr__ctor_Internal_Void_CustomControllerElementTarget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00041304 File Offset: 0x0003F504
		[CallerCount(0)]
		public unsafe override void ClearElementCaches()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomControllerElementTargetSetForBoolean.NativeMethodInfoPtr_ClearElementCaches_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x000038F8 File Offset: 0x00001AF8
		public CustomControllerElementTargetSetForBoolean(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x00041340 File Offset: 0x0003F540
		// (set) Token: 0x0600050D RID: 1293 RVA: 0x00003901 File Offset: 0x00001B01
		public unsafe static int ThZMnYXmzRIaAFXAwkoRLagiqkc
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CustomControllerElementTargetSetForBoolean.NativeFieldInfoPtr_ThZMnYXmzRIaAFXAwkoRLagiqkc, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CustomControllerElementTargetSetForBoolean.NativeFieldInfoPtr_ThZMnYXmzRIaAFXAwkoRLagiqkc, (void*)(&value));
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x0004135C File Offset: 0x0003F55C
		// (set) Token: 0x0600050F RID: 1295 RVA: 0x0000390F File Offset: 0x00001B0F
		public unsafe CustomControllerElementTarget _target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerElementTargetSetForBoolean.NativeFieldInfoPtr__target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomControllerElementTarget>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerElementTargetSetForBoolean.NativeFieldInfoPtr__target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400043F RID: 1087
		private static readonly IntPtr NativeFieldInfoPtr_ThZMnYXmzRIaAFXAwkoRLagiqkc;

		// Token: 0x04000440 RID: 1088
		private static readonly IntPtr NativeFieldInfoPtr__target;

		// Token: 0x04000441 RID: 1089
		private static readonly IntPtr NativeMethodInfoPtr_get_target_Public_get_CustomControllerElementTarget_0;

		// Token: 0x04000442 RID: 1090
		private static readonly IntPtr NativeMethodInfoPtr_get_targetCount_Internal_Virtual_get_Int32_0;

		// Token: 0x04000443 RID: 1091
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Internal_Virtual_get_CustomControllerElementTarget_Int32_0;

		// Token: 0x04000444 RID: 1092
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000445 RID: 1093
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CustomControllerElementTarget_0;

		// Token: 0x04000446 RID: 1094
		private static readonly IntPtr NativeMethodInfoPtr_ClearElementCaches_Internal_Virtual_Void_0;
	}
}
