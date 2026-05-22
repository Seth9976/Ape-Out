using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.InteropServices;

namespace Il2CppSteamworks
{
	// Token: 0x0200000F RID: 15
	public class CCallbackBaseVTable : Object
	{
		// Token: 0x06000098 RID: 152 RVA: 0x0000FD64 File Offset: 0x0000DF64
		// Note: this type is marked as 'beforefieldinit'.
		static CCallbackBaseVTable()
		{
			Il2CppClassPointerStore<CCallbackBaseVTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "CCallbackBaseVTable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CCallbackBaseVTable>.NativeClassPtr);
			CCallbackBaseVTable.NativeFieldInfoPtr_cc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CCallbackBaseVTable>.NativeClassPtr, "cc");
			CCallbackBaseVTable.NativeFieldInfoPtr_m_RunCallResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CCallbackBaseVTable>.NativeClassPtr, "m_RunCallResult");
			CCallbackBaseVTable.NativeFieldInfoPtr_m_RunCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CCallbackBaseVTable>.NativeClassPtr, "m_RunCallback");
			CCallbackBaseVTable.NativeFieldInfoPtr_m_GetCallbackSizeBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CCallbackBaseVTable>.NativeClassPtr, "m_GetCallbackSizeBytes");
			CCallbackBaseVTable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CCallbackBaseVTable>.NativeClassPtr, 100663369);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000FDF8 File Offset: 0x0000DFF8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CCallbackBaseVTable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CCallbackBaseVTable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CCallbackBaseVTable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002470 File Offset: 0x00000670
		public CCallbackBaseVTable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600009B RID: 155 RVA: 0x0000FE34 File Offset: 0x0000E034
		// (set) Token: 0x0600009C RID: 156 RVA: 0x00002479 File Offset: 0x00000679
		public unsafe static CallingConvention cc
		{
			get
			{
				CallingConvention callingConvention;
				IL2CPP.il2cpp_field_static_get_value(CCallbackBaseVTable.NativeFieldInfoPtr_cc, (void*)(&callingConvention));
				return callingConvention;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CCallbackBaseVTable.NativeFieldInfoPtr_cc, (void*)(&value));
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600009D RID: 157 RVA: 0x0000FE50 File Offset: 0x0000E050
		// (set) Token: 0x0600009E RID: 158 RVA: 0x00002487 File Offset: 0x00000687
		public unsafe CCallbackBaseVTable.RunCRDel m_RunCallResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CCallbackBaseVTable.NativeFieldInfoPtr_m_RunCallResult);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CCallbackBaseVTable.RunCRDel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CCallbackBaseVTable.NativeFieldInfoPtr_m_RunCallResult), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600009F RID: 159 RVA: 0x0000FE80 File Offset: 0x0000E080
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x000024A6 File Offset: 0x000006A6
		public unsafe CCallbackBaseVTable.RunCBDel m_RunCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CCallbackBaseVTable.NativeFieldInfoPtr_m_RunCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CCallbackBaseVTable.RunCBDel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CCallbackBaseVTable.NativeFieldInfoPtr_m_RunCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x0000FEB0 File Offset: 0x0000E0B0
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x000024C5 File Offset: 0x000006C5
		public unsafe CCallbackBaseVTable.GetCallbackSizeBytesDel m_GetCallbackSizeBytes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CCallbackBaseVTable.NativeFieldInfoPtr_m_GetCallbackSizeBytes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CCallbackBaseVTable.GetCallbackSizeBytesDel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CCallbackBaseVTable.NativeFieldInfoPtr_m_GetCallbackSizeBytes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeFieldInfoPtr_cc;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeFieldInfoPtr_m_RunCallResult;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeFieldInfoPtr_m_RunCallback;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeFieldInfoPtr_m_GetCallbackSizeBytes;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200021B RID: 539
		public sealed class RunCBDel : MulticastDelegate
		{
			// Token: 0x06001E85 RID: 7813 RVA: 0x000881E4 File Offset: 0x000863E4
			// Note: this type is marked as 'beforefieldinit'.
			static RunCBDel()
			{
				Il2CppClassPointerStore<CCallbackBaseVTable.RunCBDel>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CCallbackBaseVTable>.NativeClassPtr, "RunCBDel");
				CCallbackBaseVTable.RunCBDel.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CCallbackBaseVTable.RunCBDel>.NativeClassPtr, 100663370);
				CCallbackBaseVTable.RunCBDel.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CCallbackBaseVTable.RunCBDel>.NativeClassPtr, 100663371);
				CCallbackBaseVTable.RunCBDel.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CCallbackBaseVTable.RunCBDel>.NativeClassPtr, 100663372);
				CCallbackBaseVTable.RunCBDel.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CCallbackBaseVTable.RunCBDel>.NativeClassPtr, 100663373);
			}

			// Token: 0x06001E86 RID: 7814 RVA: 0x00088258 File Offset: 0x00086458
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RunCBDel(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CCallbackBaseVTable.RunCBDel>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CCallbackBaseVTable.RunCBDel.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E87 RID: 7815 RVA: 0x000882B4 File Offset: 0x000864B4
			[CallerCount(0)]
			public unsafe void Invoke(IntPtr thisptr, IntPtr pvParam)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CCallbackBaseVTable.RunCBDel.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E88 RID: 7816 RVA: 0x00088300 File Offset: 0x00086500
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862, XrefRangeEnd = 868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(IntPtr thisptr, IntPtr pvParam, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref thisptr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pvParam;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CCallbackBaseVTable.RunCBDel.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001E89 RID: 7817 RVA: 0x00088380 File Offset: 0x00086580
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CCallbackBaseVTable.RunCBDel.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001E8A RID: 7818 RVA: 0x0000B14D File Offset: 0x0000934D
			public RunCBDel(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001E8B RID: 7819 RVA: 0x0000B156 File Offset: 0x00009356
			public static implicit operator CCallbackBaseVTable.RunCBDel(Action<IntPtr, IntPtr> A_0)
			{
				return DelegateSupport.ConvertDelegate<CCallbackBaseVTable.RunCBDel>(A_0);
			}

			// Token: 0x06001E8C RID: 7820 RVA: 0x0000B15E File Offset: 0x0000935E
			public static CCallbackBaseVTable.RunCBDel operator +(CCallbackBaseVTable.RunCBDel A_0, CCallbackBaseVTable.RunCBDel A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<CCallbackBaseVTable.RunCBDel>();
			}

			// Token: 0x06001E8D RID: 7821 RVA: 0x0000B16C File Offset: 0x0000936C
			public static CCallbackBaseVTable.RunCBDel operator -(CCallbackBaseVTable.RunCBDel A_0, CCallbackBaseVTable.RunCBDel A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<CCallbackBaseVTable.RunCBDel>();
				}
				return delegate2;
			}

			// Token: 0x04001F58 RID: 8024
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001F59 RID: 8025
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_0;

			// Token: 0x04001F5A RID: 8026
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_AsyncCallback_Object_0;

			// Token: 0x04001F5B RID: 8027
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200021C RID: 540
		public sealed class RunCRDel : MulticastDelegate
		{
			// Token: 0x06001E8E RID: 7822 RVA: 0x000883C4 File Offset: 0x000865C4
			// Note: this type is marked as 'beforefieldinit'.
			static RunCRDel()
			{
				Il2CppClassPointerStore<CCallbackBaseVTable.RunCRDel>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CCallbackBaseVTable>.NativeClassPtr, "RunCRDel");
				CCallbackBaseVTable.RunCRDel.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CCallbackBaseVTable.RunCRDel>.NativeClassPtr, 100663374);
				CCallbackBaseVTable.RunCRDel.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_Boolean_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CCallbackBaseVTable.RunCRDel>.NativeClassPtr, 100663375);
				CCallbackBaseVTable.RunCRDel.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_Boolean_UInt64_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CCallbackBaseVTable.RunCRDel>.NativeClassPtr, 100663376);
				CCallbackBaseVTable.RunCRDel.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CCallbackBaseVTable.RunCRDel>.NativeClassPtr, 100663377);
			}

			// Token: 0x06001E8F RID: 7823 RVA: 0x00088438 File Offset: 0x00086638
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RunCRDel(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CCallbackBaseVTable.RunCRDel>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CCallbackBaseVTable.RunCRDel.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E90 RID: 7824 RVA: 0x00088494 File Offset: 0x00086694
			[CallerCount(0)]
			public unsafe void Invoke(IntPtr thisptr, IntPtr pvParam, bool bIOFailure, ulong hSteamAPICall)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref thisptr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pvParam;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bIOFailure;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamAPICall;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CCallbackBaseVTable.RunCRDel.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_Boolean_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E91 RID: 7825 RVA: 0x000884FC File Offset: 0x000866FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 868, XrefRangeEnd = 880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(IntPtr thisptr, IntPtr pvParam, bool bIOFailure, ulong hSteamAPICall, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref thisptr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pvParam;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bIOFailure;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamAPICall;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CCallbackBaseVTable.RunCRDel.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_Boolean_UInt64_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001E92 RID: 7826 RVA: 0x00088598 File Offset: 0x00086798
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CCallbackBaseVTable.RunCRDel.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001E93 RID: 7827 RVA: 0x0000B17D File Offset: 0x0000937D
			public RunCRDel(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001E94 RID: 7828 RVA: 0x0000B186 File Offset: 0x00009386
			public static implicit operator CCallbackBaseVTable.RunCRDel(Action<IntPtr, IntPtr, bool, ulong> A_0)
			{
				return DelegateSupport.ConvertDelegate<CCallbackBaseVTable.RunCRDel>(A_0);
			}

			// Token: 0x06001E95 RID: 7829 RVA: 0x0000B18E File Offset: 0x0000938E
			public static CCallbackBaseVTable.RunCRDel operator +(CCallbackBaseVTable.RunCRDel A_0, CCallbackBaseVTable.RunCRDel A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<CCallbackBaseVTable.RunCRDel>();
			}

			// Token: 0x06001E96 RID: 7830 RVA: 0x0000B19C File Offset: 0x0000939C
			public static CCallbackBaseVTable.RunCRDel operator -(CCallbackBaseVTable.RunCRDel A_0, CCallbackBaseVTable.RunCRDel A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<CCallbackBaseVTable.RunCRDel>();
				}
				return delegate2;
			}

			// Token: 0x04001F5C RID: 8028
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001F5D RID: 8029
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_Boolean_UInt64_0;

			// Token: 0x04001F5E RID: 8030
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_Boolean_UInt64_AsyncCallback_Object_0;

			// Token: 0x04001F5F RID: 8031
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200021D RID: 541
		public sealed class GetCallbackSizeBytesDel : MulticastDelegate
		{
			// Token: 0x06001E97 RID: 7831 RVA: 0x000885DC File Offset: 0x000867DC
			// Note: this type is marked as 'beforefieldinit'.
			static GetCallbackSizeBytesDel()
			{
				Il2CppClassPointerStore<CCallbackBaseVTable.GetCallbackSizeBytesDel>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CCallbackBaseVTable>.NativeClassPtr, "GetCallbackSizeBytesDel");
				CCallbackBaseVTable.GetCallbackSizeBytesDel.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CCallbackBaseVTable.GetCallbackSizeBytesDel>.NativeClassPtr, 100663378);
				CCallbackBaseVTable.GetCallbackSizeBytesDel.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CCallbackBaseVTable.GetCallbackSizeBytesDel>.NativeClassPtr, 100663379);
				CCallbackBaseVTable.GetCallbackSizeBytesDel.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CCallbackBaseVTable.GetCallbackSizeBytesDel>.NativeClassPtr, 100663380);
				CCallbackBaseVTable.GetCallbackSizeBytesDel.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CCallbackBaseVTable.GetCallbackSizeBytesDel>.NativeClassPtr, 100663381);
			}

			// Token: 0x06001E98 RID: 7832 RVA: 0x00088650 File Offset: 0x00086850
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GetCallbackSizeBytesDel(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CCallbackBaseVTable.GetCallbackSizeBytesDel>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CCallbackBaseVTable.GetCallbackSizeBytesDel.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E99 RID: 7833 RVA: 0x000886AC File Offset: 0x000868AC
			[CallerCount(0)]
			public unsafe int Invoke(IntPtr thisptr)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref thisptr;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CCallbackBaseVTable.GetCallbackSizeBytesDel.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001E9A RID: 7834 RVA: 0x000886F8 File Offset: 0x000868F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880, XrefRangeEnd = 884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(IntPtr thisptr, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref thisptr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CCallbackBaseVTable.GetCallbackSizeBytesDel.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001E9B RID: 7835 RVA: 0x00088768 File Offset: 0x00086968
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884, XrefRangeEnd = 885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CCallbackBaseVTable.GetCallbackSizeBytesDel.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001E9C RID: 7836 RVA: 0x0000B1AD File Offset: 0x000093AD
			public GetCallbackSizeBytesDel(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001E9D RID: 7837 RVA: 0x0000B1B6 File Offset: 0x000093B6
			public static implicit operator CCallbackBaseVTable.GetCallbackSizeBytesDel(Func<IntPtr, int> A_0)
			{
				return DelegateSupport.ConvertDelegate<CCallbackBaseVTable.GetCallbackSizeBytesDel>(A_0);
			}

			// Token: 0x06001E9E RID: 7838 RVA: 0x0000B1BE File Offset: 0x000093BE
			public static CCallbackBaseVTable.GetCallbackSizeBytesDel operator +(CCallbackBaseVTable.GetCallbackSizeBytesDel A_0, CCallbackBaseVTable.GetCallbackSizeBytesDel A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<CCallbackBaseVTable.GetCallbackSizeBytesDel>();
			}

			// Token: 0x06001E9F RID: 7839 RVA: 0x0000B1CC File Offset: 0x000093CC
			public static CCallbackBaseVTable.GetCallbackSizeBytesDel operator -(CCallbackBaseVTable.GetCallbackSizeBytesDel A_0, CCallbackBaseVTable.GetCallbackSizeBytesDel A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<CCallbackBaseVTable.GetCallbackSizeBytesDel>();
				}
				return delegate2;
			}

			// Token: 0x04001F60 RID: 8032
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001F61 RID: 8033
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_IntPtr_0;

			// Token: 0x04001F62 RID: 8034
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0;

			// Token: 0x04001F63 RID: 8035
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0;
		}
	}
}
