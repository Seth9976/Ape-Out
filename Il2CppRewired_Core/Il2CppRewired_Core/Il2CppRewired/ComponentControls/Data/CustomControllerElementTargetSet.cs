using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.ComponentControls.Data
{
	// Token: 0x02000040 RID: 64
	[Serializable]
	public class CustomControllerElementTargetSet : Object
	{
		// Token: 0x060004FE RID: 1278 RVA: 0x00040F34 File Offset: 0x0003F134
		// Note: this type is marked as 'beforefieldinit'.
		static CustomControllerElementTargetSet()
		{
			Il2CppClassPointerStore<CustomControllerElementTargetSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.ComponentControls.Data", "CustomControllerElementTargetSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomControllerElementTargetSet>.NativeClassPtr);
			CustomControllerElementTargetSet.NativeMethodInfoPtr_get_targetCount_Internal_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerElementTargetSet>.NativeClassPtr, 100664161);
			CustomControllerElementTargetSet.NativeMethodInfoPtr_get_Item_Internal_Abstract_Virtual_New_get_CustomControllerElementTarget_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerElementTargetSet>.NativeClassPtr, 100664162);
			CustomControllerElementTargetSet.NativeMethodInfoPtr_ClearElementCaches_Internal_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerElementTargetSet>.NativeClassPtr, 100664163);
			CustomControllerElementTargetSet.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerElementTargetSet>.NativeClassPtr, 100664164);
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060004FF RID: 1279 RVA: 0x00040FB4 File Offset: 0x0003F1B4
		public unsafe virtual int targetCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomControllerElementTargetSet.NativeMethodInfoPtr_get_targetCount_Internal_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700018C RID: 396
		public unsafe virtual CustomControllerElementTarget this[int index]
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomControllerElementTargetSet.NativeMethodInfoPtr_get_Item_Internal_Abstract_Virtual_New_get_CustomControllerElementTarget_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomControllerElementTarget>(intPtr3) : null;
				}
			}
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00041054 File Offset: 0x0003F254
		[CallerCount(0)]
		public unsafe virtual void ClearElementCaches()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomControllerElementTargetSet.NativeMethodInfoPtr_ClearElementCaches_Internal_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00041090 File Offset: 0x0003F290
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomControllerElementTargetSet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomControllerElementTargetSet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerElementTargetSet.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x000038EF File Offset: 0x00001AEF
		public CustomControllerElementTargetSet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400043B RID: 1083
		private static readonly IntPtr NativeMethodInfoPtr_get_targetCount_Internal_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x0400043C RID: 1084
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Internal_Abstract_Virtual_New_get_CustomControllerElementTarget_Int32_0;

		// Token: 0x0400043D RID: 1085
		private static readonly IntPtr NativeMethodInfoPtr_ClearElementCaches_Internal_Abstract_Virtual_New_Void_0;

		// Token: 0x0400043E RID: 1086
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
