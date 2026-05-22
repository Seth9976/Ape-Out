using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Timeline
{
	// Token: 0x0200002B RID: 43
	[Serializable]
	public class SignalEmitter : Marker
	{
		// Token: 0x060003D8 RID: 984 RVA: 0x000138F8 File Offset: 0x00011AF8
		// Note: this type is marked as 'beforefieldinit'.
		static SignalEmitter()
		{
			Il2CppClassPointerStore<SignalEmitter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "SignalEmitter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SignalEmitter>.NativeClassPtr);
			SignalEmitter.NativeFieldInfoPtr_m_Retroactive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignalEmitter>.NativeClassPtr, "m_Retroactive");
			SignalEmitter.NativeFieldInfoPtr_m_EmitOnce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignalEmitter>.NativeClassPtr, "m_EmitOnce");
			SignalEmitter.NativeFieldInfoPtr_m_Asset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignalEmitter>.NativeClassPtr, "m_Asset");
			SignalEmitter.NativeMethodInfoPtr_get_retroactive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalEmitter>.NativeClassPtr, 100663947);
			SignalEmitter.NativeMethodInfoPtr_set_retroactive_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalEmitter>.NativeClassPtr, 100663948);
			SignalEmitter.NativeMethodInfoPtr_get_emitOnce_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalEmitter>.NativeClassPtr, 100663949);
			SignalEmitter.NativeMethodInfoPtr_set_emitOnce_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalEmitter>.NativeClassPtr, 100663950);
			SignalEmitter.NativeMethodInfoPtr_get_asset_Public_get_SignalAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalEmitter>.NativeClassPtr, 100663951);
			SignalEmitter.NativeMethodInfoPtr_set_asset_Public_set_Void_SignalAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalEmitter>.NativeClassPtr, 100663952);
			SignalEmitter.NativeMethodInfoPtr_UnityEngine_Playables_INotification_get_id_Private_Virtual_Final_New_get_PropertyName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalEmitter>.NativeClassPtr, 100663953);
			SignalEmitter.NativeMethodInfoPtr_UnityEngine_Timeline_INotificationOptionProvider_get_flags_Private_Virtual_Final_New_get_NotificationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalEmitter>.NativeClassPtr, 100663954);
			SignalEmitter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalEmitter>.NativeClassPtr, 100663955);
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060003D9 RID: 985 RVA: 0x00013A18 File Offset: 0x00011C18
		// (set) Token: 0x060003DA RID: 986 RVA: 0x00013A54 File Offset: 0x00011C54
		public unsafe bool retroactive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignalEmitter.NativeMethodInfoPtr_get_retroactive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignalEmitter.NativeMethodInfoPtr_set_retroactive_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060003DB RID: 987 RVA: 0x00013A94 File Offset: 0x00011C94
		// (set) Token: 0x060003DC RID: 988 RVA: 0x00013AD0 File Offset: 0x00011CD0
		public unsafe bool emitOnce
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignalEmitter.NativeMethodInfoPtr_get_emitOnce_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignalEmitter.NativeMethodInfoPtr_set_emitOnce_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060003DD RID: 989 RVA: 0x00013B10 File Offset: 0x00011D10
		// (set) Token: 0x060003DE RID: 990 RVA: 0x00013B50 File Offset: 0x00011D50
		public unsafe SignalAsset asset
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignalEmitter.NativeMethodInfoPtr_get_asset_Public_get_SignalAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SignalAsset>(intPtr3) : null;
			}
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 14017, RefRangeEnd = 14055, XrefRangeStart = 14017, XrefRangeEnd = 14055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignalEmitter.NativeMethodInfoPtr_set_asset_Public_set_Void_SignalAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060003DF RID: 991 RVA: 0x00013B94 File Offset: 0x00011D94
		public unsafe virtual PropertyName UnityEngine.Playables.INotification.id
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478065, XrefRangeEnd = 478085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignalEmitter.NativeMethodInfoPtr_UnityEngine_Playables_INotification_get_id_Private_Virtual_Final_New_get_PropertyName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x00013BD0 File Offset: 0x00011DD0
		public unsafe virtual NotificationFlags UnityEngine.Timeline.INotificationOptionProvider.flags
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignalEmitter.NativeMethodInfoPtr_UnityEngine_Timeline_INotificationOptionProvider_get_flags_Private_Virtual_Final_New_get_NotificationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00013C0C File Offset: 0x00011E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SignalEmitter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SignalEmitter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignalEmitter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x000033C6 File Offset: 0x000015C6
		public SignalEmitter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x00013C48 File Offset: 0x00011E48
		// (set) Token: 0x060003E4 RID: 996 RVA: 0x000033CF File Offset: 0x000015CF
		public unsafe bool m_Retroactive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignalEmitter.NativeFieldInfoPtr_m_Retroactive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignalEmitter.NativeFieldInfoPtr_m_Retroactive)) = value;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060003E5 RID: 997 RVA: 0x00013C70 File Offset: 0x00011E70
		// (set) Token: 0x060003E6 RID: 998 RVA: 0x000033EA File Offset: 0x000015EA
		public unsafe bool m_EmitOnce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignalEmitter.NativeFieldInfoPtr_m_EmitOnce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignalEmitter.NativeFieldInfoPtr_m_EmitOnce)) = value;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060003E7 RID: 999 RVA: 0x00013C98 File Offset: 0x00011E98
		// (set) Token: 0x060003E8 RID: 1000 RVA: 0x00003405 File Offset: 0x00001605
		public unsafe SignalAsset m_Asset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignalEmitter.NativeFieldInfoPtr_m_Asset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SignalAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignalEmitter.NativeFieldInfoPtr_m_Asset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400030B RID: 779
		private static readonly IntPtr NativeFieldInfoPtr_m_Retroactive;

		// Token: 0x0400030C RID: 780
		private static readonly IntPtr NativeFieldInfoPtr_m_EmitOnce;

		// Token: 0x0400030D RID: 781
		private static readonly IntPtr NativeFieldInfoPtr_m_Asset;

		// Token: 0x0400030E RID: 782
		private static readonly IntPtr NativeMethodInfoPtr_get_retroactive_Public_get_Boolean_0;

		// Token: 0x0400030F RID: 783
		private static readonly IntPtr NativeMethodInfoPtr_set_retroactive_Public_set_Void_Boolean_0;

		// Token: 0x04000310 RID: 784
		private static readonly IntPtr NativeMethodInfoPtr_get_emitOnce_Public_get_Boolean_0;

		// Token: 0x04000311 RID: 785
		private static readonly IntPtr NativeMethodInfoPtr_set_emitOnce_Public_set_Void_Boolean_0;

		// Token: 0x04000312 RID: 786
		private static readonly IntPtr NativeMethodInfoPtr_get_asset_Public_get_SignalAsset_0;

		// Token: 0x04000313 RID: 787
		private static readonly IntPtr NativeMethodInfoPtr_set_asset_Public_set_Void_SignalAsset_0;

		// Token: 0x04000314 RID: 788
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_Playables_INotification_get_id_Private_Virtual_Final_New_get_PropertyName_0;

		// Token: 0x04000315 RID: 789
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_Timeline_INotificationOptionProvider_get_flags_Private_Virtual_Final_New_get_NotificationFlags_0;

		// Token: 0x04000316 RID: 790
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
