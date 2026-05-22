using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Utils.Classes.Utility
{
	// Token: 0x0200020F RID: 527
	public class ValueWatcher : Object
	{
		// Token: 0x060036C6 RID: 14022 RVA: 0x0010EDF4 File Offset: 0x0010CFF4
		// Note: this type is marked as 'beforefieldinit'.
		static ValueWatcher()
		{
			Il2CppClassPointerStore<ValueWatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Classes.Utility", "ValueWatcher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValueWatcher>.NativeClassPtr);
			ValueWatcher.NativeMethodInfoPtr_get_changed_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueWatcher>.NativeClassPtr, 100676793);
			ValueWatcher.NativeMethodInfoPtr_get_autoTriggerEvent_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueWatcher>.NativeClassPtr, 100676794);
			ValueWatcher.NativeMethodInfoPtr_set_autoTriggerEvent_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueWatcher>.NativeClassPtr, 100676795);
			ValueWatcher.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueWatcher>.NativeClassPtr, 100676796);
			ValueWatcher.NativeMethodInfoPtr_Use_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueWatcher>.NativeClassPtr, 100676797);
			ValueWatcher.NativeMethodInfoPtr_TriggerEvent_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueWatcher>.NativeClassPtr, 100676798);
			ValueWatcher.NativeMethodInfoPtr_AddEventListener_Public_Abstract_Virtual_New_Void_TyGXyaSQkKibFXAQOIezQJzuDUL_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueWatcher>.NativeClassPtr, 100676799);
			ValueWatcher.NativeMethodInfoPtr_RemoveEventListener_Public_Abstract_Virtual_New_Void_TyGXyaSQkKibFXAQOIezQJzuDUL_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueWatcher>.NativeClassPtr, 100676800);
			ValueWatcher.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueWatcher>.NativeClassPtr, 100676801);
		}

		// Token: 0x17001060 RID: 4192
		// (get) Token: 0x060036C7 RID: 14023 RVA: 0x0010EED8 File Offset: 0x0010D0D8
		public unsafe virtual bool changed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ValueWatcher.NativeMethodInfoPtr_get_changed_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001061 RID: 4193
		// (get) Token: 0x060036C8 RID: 14024 RVA: 0x0010EF20 File Offset: 0x0010D120
		// (set) Token: 0x060036C9 RID: 14025 RVA: 0x0010EF68 File Offset: 0x0010D168
		public unsafe virtual bool autoTriggerEvent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ValueWatcher.NativeMethodInfoPtr_get_autoTriggerEvent_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ValueWatcher.NativeMethodInfoPtr_set_autoTriggerEvent_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060036CA RID: 14026 RVA: 0x0010EFB4 File Offset: 0x0010D1B4
		[CallerCount(0)]
		public unsafe virtual bool Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ValueWatcher.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060036CB RID: 14027 RVA: 0x0010EFFC File Offset: 0x0010D1FC
		[CallerCount(0)]
		public unsafe virtual bool Use()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ValueWatcher.NativeMethodInfoPtr_Use_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060036CC RID: 14028 RVA: 0x0010F044 File Offset: 0x0010D244
		[CallerCount(0)]
		public unsafe virtual bool TriggerEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ValueWatcher.NativeMethodInfoPtr_TriggerEvent_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060036CD RID: 14029 RVA: 0x0010F08C File Offset: 0x0010D28C
		[CallerCount(0)]
		public unsafe virtual void AddEventListener(ValueWatcher.TyGXyaSQkKibFXAQOIezQJzuDUL eventType, Delegate listener)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listener);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ValueWatcher.NativeMethodInfoPtr_AddEventListener_Public_Abstract_Virtual_New_Void_TyGXyaSQkKibFXAQOIezQJzuDUL_Delegate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036CE RID: 14030 RVA: 0x0010F0E8 File Offset: 0x0010D2E8
		[CallerCount(0)]
		public unsafe virtual void RemoveEventListener(ValueWatcher.TyGXyaSQkKibFXAQOIezQJzuDUL eventType, Delegate listener)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listener);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ValueWatcher.NativeMethodInfoPtr_RemoveEventListener_Public_Abstract_Virtual_New_Void_TyGXyaSQkKibFXAQOIezQJzuDUL_Delegate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036CF RID: 14031 RVA: 0x0010F144 File Offset: 0x0010D344
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueWatcher()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueWatcher>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueWatcher.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036D0 RID: 14032 RVA: 0x00012E01 File Offset: 0x00011001
		public ValueWatcher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002E6B RID: 11883
		private static readonly IntPtr NativeMethodInfoPtr_get_changed_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04002E6C RID: 11884
		private static readonly IntPtr NativeMethodInfoPtr_get_autoTriggerEvent_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04002E6D RID: 11885
		private static readonly IntPtr NativeMethodInfoPtr_set_autoTriggerEvent_Public_Abstract_Virtual_New_set_Void_Boolean_0;

		// Token: 0x04002E6E RID: 11886
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04002E6F RID: 11887
		private static readonly IntPtr NativeMethodInfoPtr_Use_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04002E70 RID: 11888
		private static readonly IntPtr NativeMethodInfoPtr_TriggerEvent_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04002E71 RID: 11889
		private static readonly IntPtr NativeMethodInfoPtr_AddEventListener_Public_Abstract_Virtual_New_Void_TyGXyaSQkKibFXAQOIezQJzuDUL_Delegate_0;

		// Token: 0x04002E72 RID: 11890
		private static readonly IntPtr NativeMethodInfoPtr_RemoveEventListener_Public_Abstract_Virtual_New_Void_TyGXyaSQkKibFXAQOIezQJzuDUL_Delegate_0;

		// Token: 0x04002E73 RID: 11891
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x020004AC RID: 1196
		[OriginalName("Rewired_Core.dll", "", "TyGXyaSQkKibFXAQOIezQJzuDUL")]
		public enum TyGXyaSQkKibFXAQOIezQJzuDUL
		{
			// Token: 0x040044B0 RID: 17584
			eEwGjKBZOeHFinyNzwKfJmVfNowP
		}
	}
}
