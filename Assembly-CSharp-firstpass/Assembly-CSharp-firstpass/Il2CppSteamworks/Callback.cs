using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.InteropServices;

namespace Il2CppSteamworks
{
	// Token: 0x0200000C RID: 12
	public sealed class Callback<T> : Object
	{
		// Token: 0x06000042 RID: 66 RVA: 0x0000EAE4 File Offset: 0x0000CCE4
		// Note: this type is marked as 'beforefieldinit'.
		static Callback()
		{
			Il2CppClassPointerStore<Callback<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "Callback`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Callback<T>>.NativeClassPtr);
			Callback<T>.NativeFieldInfoPtr_m_CallbackBaseVTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Callback<T>>.NativeClassPtr, "m_CallbackBaseVTable");
			Callback<T>.NativeFieldInfoPtr_m_pVTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Callback<T>>.NativeClassPtr, "m_pVTable");
			Callback<T>.NativeFieldInfoPtr_m_CCallbackBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Callback<T>>.NativeClassPtr, "m_CCallbackBase");
			Callback<T>.NativeFieldInfoPtr_m_pCCallbackBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Callback<T>>.NativeClassPtr, "m_pCCallbackBase");
			Callback<T>.NativeFieldInfoPtr_m_Func = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Callback<T>>.NativeClassPtr, "m_Func");
			Callback<T>.NativeFieldInfoPtr_m_bGameServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Callback<T>>.NativeClassPtr, "m_bGameServer");
			Callback<T>.NativeFieldInfoPtr_m_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Callback<T>>.NativeClassPtr, "m_size");
			Callback<T>.NativeFieldInfoPtr_m_bDisposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Callback<T>>.NativeClassPtr, "m_bDisposed");
			Callback<T>.NativeMethodInfoPtr_add_m_Func_Private_add_Void_DispatchDelegate_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Callback<T>>.NativeClassPtr, 100663324);
			Callback<T>.NativeMethodInfoPtr_remove_m_Func_Private_rem_Void_DispatchDelegate_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Callback<T>>.NativeClassPtr, 100663325);
			Callback<T>.NativeMethodInfoPtr_Create_Public_Static_Callback_1_T_DispatchDelegate_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Callback<T>>.NativeClassPtr, 100663326);
			Callback<T>.NativeMethodInfoPtr_CreateGameServer_Public_Static_Callback_1_T_DispatchDelegate_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Callback<T>>.NativeClassPtr, 100663327);
			Callback<T>.NativeMethodInfoPtr__ctor_Public_Void_DispatchDelegate_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Callback<T>>.NativeClassPtr, 100663328);
			Callback<T>.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Callback<T>>.NativeClassPtr, 100663329);
			Callback<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Callback<T>>.NativeClassPtr, 100663330);
			Callback<T>.NativeMethodInfoPtr_Register_Public_Void_DispatchDelegate_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Callback<T>>.NativeClassPtr, 100663331);
			Callback<T>.NativeMethodInfoPtr_Unregister_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Callback<T>>.NativeClassPtr, 100663332);
			Callback<T>.NativeMethodInfoPtr_SetGameserverFlag_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Callback<T>>.NativeClassPtr, 100663333);
			Callback<T>.NativeMethodInfoPtr_OnRunCallback_Public_Virtual_Final_New_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Callback<T>>.NativeClassPtr, 100663334);
			Callback<T>.NativeMethodInfoPtr_OnRunCallResult_Public_Virtual_Final_New_Void_IntPtr_IntPtr_Boolean_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Callback<T>>.NativeClassPtr, 100663335);
			Callback<T>.NativeMethodInfoPtr_OnGetCallbackSizeBytes_Public_Virtual_Final_New_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Callback<T>>.NativeClassPtr, 100663336);
			Callback<T>.NativeMethodInfoPtr_BuildCCallbackBase_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Callback<T>>.NativeClassPtr, 100663337);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0000ED08 File Offset: 0x0000CF08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 450, XrefRangeEnd = 457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_m_Func(Callback<T>.DispatchDelegate value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Callback<T>.NativeMethodInfoPtr_add_m_Func_Private_add_Void_DispatchDelegate_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0000ED4C File Offset: 0x0000CF4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 457, XrefRangeEnd = 464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_m_Func(Callback<T>.DispatchDelegate value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Callback<T>.NativeMethodInfoPtr_remove_m_Func_Private_rem_Void_DispatchDelegate_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000ED90 File Offset: 0x0000CF90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464, XrefRangeEnd = 469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Callback<T> Create(Callback<T>.DispatchDelegate func)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Callback<T>.NativeMethodInfoPtr_Create_Public_Static_Callback_1_T_DispatchDelegate_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Callback<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000EDD4 File Offset: 0x0000CFD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 469, XrefRangeEnd = 474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Callback<T> CreateGameServer(Callback<T>.DispatchDelegate func)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Callback<T>.NativeMethodInfoPtr_CreateGameServer_Public_Static_Callback_1_T_DispatchDelegate_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Callback<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000EE18 File Offset: 0x0000D018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474, XrefRangeEnd = 483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Callback(Callback<T>.DispatchDelegate func, bool bGameServer = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Callback<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bGameServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Callback<T>.NativeMethodInfoPtr__ctor_Public_Void_DispatchDelegate_T_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000EE74 File Offset: 0x0000D074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483, XrefRangeEnd = 484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Callback<T>.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000EEA8 File Offset: 0x0000D0A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484, XrefRangeEnd = 498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Callback<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000EEDC File Offset: 0x0000D0DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498, XrefRangeEnd = 512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Register(Callback<T>.DispatchDelegate func)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Callback<T>.NativeMethodInfoPtr_Register_Public_Void_DispatchDelegate_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000EF20 File Offset: 0x0000D120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512, XrefRangeEnd = 514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unregister()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Callback<T>.NativeMethodInfoPtr_Unregister_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000EF54 File Offset: 0x0000D154
		[CallerCount(0)]
		public unsafe void SetGameserverFlag()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Callback<T>.NativeMethodInfoPtr_SetGameserverFlag_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000EF88 File Offset: 0x0000D188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514, XrefRangeEnd = 525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnRunCallback(IntPtr thisptr, IntPtr pvParam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref thisptr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pvParam;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Callback<T>.NativeMethodInfoPtr_OnRunCallback_Public_Virtual_Final_New_Void_IntPtr_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0000EFD4 File Offset: 0x0000D1D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525, XrefRangeEnd = 536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnRunCallResult(IntPtr thisptr, IntPtr pvParam, bool bFailed, ulong hSteamAPICall)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref thisptr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pvParam;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bFailed;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamAPICall;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Callback<T>.NativeMethodInfoPtr_OnRunCallResult_Public_Virtual_Final_New_Void_IntPtr_IntPtr_Boolean_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x0000F03C File Offset: 0x0000D23C
		[CallerCount(0)]
		public unsafe int OnGetCallbackSizeBytes(IntPtr thisptr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref thisptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Callback<T>.NativeMethodInfoPtr_OnGetCallbackSizeBytes_Public_Virtual_Final_New_Int32_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000F088 File Offset: 0x0000D288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536, XrefRangeEnd = 614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildCCallbackBase()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Callback<T>.NativeMethodInfoPtr_BuildCCallbackBase_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000220E File Offset: 0x0000040E
		public Callback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000052 RID: 82 RVA: 0x0000F0BC File Offset: 0x0000D2BC
		// (set) Token: 0x06000053 RID: 83 RVA: 0x00002217 File Offset: 0x00000417
		public unsafe CCallbackBaseVTable m_CallbackBaseVTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Callback<T>.NativeFieldInfoPtr_m_CallbackBaseVTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CCallbackBaseVTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Callback<T>.NativeFieldInfoPtr_m_CallbackBaseVTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000054 RID: 84 RVA: 0x0000F0EC File Offset: 0x0000D2EC
		// (set) Token: 0x06000055 RID: 85 RVA: 0x00002236 File Offset: 0x00000436
		public unsafe IntPtr m_pVTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Callback<T>.NativeFieldInfoPtr_m_pVTable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Callback<T>.NativeFieldInfoPtr_m_pVTable)) = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000056 RID: 86 RVA: 0x0000F114 File Offset: 0x0000D314
		// (set) Token: 0x06000057 RID: 87 RVA: 0x00002251 File Offset: 0x00000451
		public unsafe CCallbackBase m_CCallbackBase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Callback<T>.NativeFieldInfoPtr_m_CCallbackBase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CCallbackBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Callback<T>.NativeFieldInfoPtr_m_CCallbackBase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000058 RID: 88 RVA: 0x0000F144 File Offset: 0x0000D344
		// (set) Token: 0x06000059 RID: 89 RVA: 0x00002270 File Offset: 0x00000470
		public unsafe GCHandle m_pCCallbackBase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Callback<T>.NativeFieldInfoPtr_m_pCCallbackBase);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Callback<T>.NativeFieldInfoPtr_m_pCCallbackBase)) = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600005A RID: 90 RVA: 0x0000F16C File Offset: 0x0000D36C
		// (set) Token: 0x0600005B RID: 91 RVA: 0x0000228B File Offset: 0x0000048B
		public unsafe Callback<T>.DispatchDelegate m_Func
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Callback<T>.NativeFieldInfoPtr_m_Func);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Callback<T>.DispatchDelegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Callback<T>.NativeFieldInfoPtr_m_Func), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600005C RID: 92 RVA: 0x0000F19C File Offset: 0x0000D39C
		// (set) Token: 0x0600005D RID: 93 RVA: 0x000022AA File Offset: 0x000004AA
		public unsafe bool m_bGameServer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Callback<T>.NativeFieldInfoPtr_m_bGameServer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Callback<T>.NativeFieldInfoPtr_m_bGameServer)) = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600005E RID: 94 RVA: 0x0000F1C4 File Offset: 0x0000D3C4
		// (set) Token: 0x0600005F RID: 95 RVA: 0x000022C5 File Offset: 0x000004C5
		public unsafe int m_size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Callback<T>.NativeFieldInfoPtr_m_size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Callback<T>.NativeFieldInfoPtr_m_size)) = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000060 RID: 96 RVA: 0x0000F1EC File Offset: 0x0000D3EC
		// (set) Token: 0x06000061 RID: 97 RVA: 0x000022E0 File Offset: 0x000004E0
		public unsafe bool m_bDisposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Callback<T>.NativeFieldInfoPtr_m_bDisposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Callback<T>.NativeFieldInfoPtr_m_bDisposed)) = value;
			}
		}

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeFieldInfoPtr_m_CallbackBaseVTable;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeFieldInfoPtr_m_pVTable;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeFieldInfoPtr_m_CCallbackBase;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeFieldInfoPtr_m_pCCallbackBase;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeFieldInfoPtr_m_Func;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeFieldInfoPtr_m_bGameServer;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeFieldInfoPtr_m_size;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeFieldInfoPtr_m_bDisposed;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr_add_m_Func_Private_add_Void_DispatchDelegate_T_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_remove_m_Func_Private_rem_Void_DispatchDelegate_T_0;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Callback_1_T_DispatchDelegate_T_0;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_CreateGameServer_Public_Static_Callback_1_T_DispatchDelegate_T_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DispatchDelegate_T_Boolean_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_Register_Public_Void_DispatchDelegate_T_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_Unregister_Public_Void_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_SetGameserverFlag_Public_Void_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_OnRunCallback_Public_Virtual_Final_New_Void_IntPtr_IntPtr_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_OnRunCallResult_Public_Virtual_Final_New_Void_IntPtr_IntPtr_Boolean_UInt64_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_OnGetCallbackSizeBytes_Public_Virtual_Final_New_Int32_IntPtr_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_BuildCCallbackBase_Private_Void_0;

		// Token: 0x02000219 RID: 537
		public sealed class DispatchDelegate : MulticastDelegate
		{
			// Token: 0x06001E73 RID: 7795 RVA: 0x00087C90 File Offset: 0x00085E90
			// Note: this type is marked as 'beforefieldinit'.
			static DispatchDelegate()
			{
				Il2CppClassPointerStore<Callback<T>.DispatchDelegate>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Callback<T>>.NativeClassPtr, "DispatchDelegate"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				Callback<T>.DispatchDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Callback<T>.DispatchDelegate>.NativeClassPtr, 100663338);
				Callback<T>.DispatchDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Callback<T>.DispatchDelegate>.NativeClassPtr, 100663339);
				Callback<T>.DispatchDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Callback<T>.DispatchDelegate>.NativeClassPtr, 100663340);
				Callback<T>.DispatchDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Callback<T>.DispatchDelegate>.NativeClassPtr, 100663341);
			}

			// Token: 0x06001E74 RID: 7796 RVA: 0x00087D3C File Offset: 0x00085F3C
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DispatchDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Callback<T>.DispatchDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Callback<T>.DispatchDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E75 RID: 7797 RVA: 0x00087D98 File Offset: 0x00085F98
			[CallerCount(0)]
			public unsafe void Invoke(T param)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					IntPtr* ptr2 = ptr;
					ref T ptr4;
					if (!typeof(T).IsValueType)
					{
						T t = param;
						if (!(t is string))
						{
							ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
							if ((ref ptr3) != null)
							{
								ptr4 = ref ptr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
								{
									ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
								}
							}
						}
						else
						{
							ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
						}
					}
					else
					{
						ptr4 = ref param;
					}
					*ptr2 = ref ptr4;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Callback<T>.DispatchDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001E76 RID: 7798 RVA: 0x00087E28 File Offset: 0x00086028
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 445, XrefRangeEnd = 449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(T param, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					IntPtr* ptr2 = ptr;
					ref T ptr4;
					if (!typeof(T).IsValueType)
					{
						T t = param;
						if (!(t is string))
						{
							ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
							if ((ref ptr3) != null)
							{
								ptr4 = ref ptr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
								{
									ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
								}
							}
						}
						else
						{
							ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
						}
					}
					else
					{
						ptr4 = ref param;
					}
					*ptr2 = ref ptr4;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Callback<T>.DispatchDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001E77 RID: 7799 RVA: 0x00087EE8 File Offset: 0x000860E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 449, XrefRangeEnd = 450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Callback<T>.DispatchDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001E78 RID: 7800 RVA: 0x0000B0ED File Offset: 0x000092ED
			public DispatchDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001E79 RID: 7801 RVA: 0x0000B0F6 File Offset: 0x000092F6
			public static implicit operator Callback<T>.DispatchDelegate(Action<T> A_0)
			{
				return DelegateSupport.ConvertDelegate<Callback<T>.DispatchDelegate>(A_0);
			}

			// Token: 0x06001E7A RID: 7802 RVA: 0x0000B0FE File Offset: 0x000092FE
			public static Callback<T>.DispatchDelegate operator +(Callback<T>.DispatchDelegate A_0, Callback<T>.DispatchDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Callback<T>.DispatchDelegate>();
			}

			// Token: 0x06001E7B RID: 7803 RVA: 0x0000B10C File Offset: 0x0000930C
			public static Callback<T>.DispatchDelegate operator -(Callback<T>.DispatchDelegate A_0, Callback<T>.DispatchDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<Callback<T>.DispatchDelegate>();
				}
				return delegate2;
			}

			// Token: 0x04001F50 RID: 8016
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001F51 RID: 8017
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T_0;

			// Token: 0x04001F52 RID: 8018
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T_AsyncCallback_Object_0;

			// Token: 0x04001F53 RID: 8019
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
