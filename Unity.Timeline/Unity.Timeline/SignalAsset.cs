using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Timeline
{
	// Token: 0x0200002A RID: 42
	public class SignalAsset : ScriptableObject
	{
		// Token: 0x060003D0 RID: 976 RVA: 0x0001375C File Offset: 0x0001195C
		// Note: this type is marked as 'beforefieldinit'.
		static SignalAsset()
		{
			Il2CppClassPointerStore<SignalAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "SignalAsset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SignalAsset>.NativeClassPtr);
			SignalAsset.NativeFieldInfoPtr_OnEnableCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignalAsset>.NativeClassPtr, "OnEnableCallback");
			SignalAsset.NativeMethodInfoPtr_add_OnEnableCallback_Internal_Static_add_Void_Action_1_SignalAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalAsset>.NativeClassPtr, 100663943);
			SignalAsset.NativeMethodInfoPtr_remove_OnEnableCallback_Internal_Static_rem_Void_Action_1_SignalAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalAsset>.NativeClassPtr, 100663944);
			SignalAsset.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalAsset>.NativeClassPtr, 100663945);
			SignalAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalAsset>.NativeClassPtr, 100663946);
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x000137F0 File Offset: 0x000119F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478048, XrefRangeEnd = 478054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnEnableCallback(Action<SignalAsset> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignalAsset.NativeMethodInfoPtr_add_OnEnableCallback_Internal_Static_add_Void_Action_1_SignalAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00013828 File Offset: 0x00011A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478054, XrefRangeEnd = 478060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnEnableCallback(Action<SignalAsset> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignalAsset.NativeMethodInfoPtr_remove_OnEnableCallback_Internal_Static_rem_Void_Action_1_SignalAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00013860 File Offset: 0x00011A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478060, XrefRangeEnd = 478065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignalAsset.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00013894 File Offset: 0x00011A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SignalAsset()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SignalAsset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignalAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x000033AB File Offset: 0x000015AB
		public SignalAsset(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x000138D0 File Offset: 0x00011AD0
		// (set) Token: 0x060003D7 RID: 983 RVA: 0x000033B4 File Offset: 0x000015B4
		public unsafe static Action<SignalAsset> OnEnableCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SignalAsset.NativeFieldInfoPtr_OnEnableCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SignalAsset>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SignalAsset.NativeFieldInfoPtr_OnEnableCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000306 RID: 774
		private static readonly IntPtr NativeFieldInfoPtr_OnEnableCallback;

		// Token: 0x04000307 RID: 775
		private static readonly IntPtr NativeMethodInfoPtr_add_OnEnableCallback_Internal_Static_add_Void_Action_1_SignalAsset_0;

		// Token: 0x04000308 RID: 776
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnEnableCallback_Internal_Static_rem_Void_Action_1_SignalAsset_0;

		// Token: 0x04000309 RID: 777
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0400030A RID: 778
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
