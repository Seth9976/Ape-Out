using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Windows.Speech
{
	// Token: 0x02000111 RID: 273
	public static class PhraseRecognitionSystem : Object
	{
		// Token: 0x0600171F RID: 5919 RVA: 0x00059918 File Offset: 0x00057B18
		// Note: this type is marked as 'beforefieldinit'.
		static PhraseRecognitionSystem()
		{
			Il2CppClassPointerStore<PhraseRecognitionSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Windows.Speech", "PhraseRecognitionSystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhraseRecognitionSystem>.NativeClassPtr);
			PhraseRecognitionSystem.NativeFieldInfoPtr_OnError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognitionSystem>.NativeClassPtr, "OnError");
			PhraseRecognitionSystem.NativeFieldInfoPtr_OnStatusChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognitionSystem>.NativeClassPtr, "OnStatusChanged");
			PhraseRecognitionSystem.NativeMethodInfoPtr_PhraseRecognitionSystem_InvokeErrorEvent_Private_Static_Void_SpeechError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognitionSystem>.NativeClassPtr, 100665349);
			PhraseRecognitionSystem.NativeMethodInfoPtr_PhraseRecognitionSystem_InvokeStatusChangedEvent_Private_Static_Void_SpeechSystemStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognitionSystem>.NativeClassPtr, 100665350);
		}

		// Token: 0x06001720 RID: 5920 RVA: 0x00059998 File Offset: 0x00057B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500350, XrefRangeEnd = 500353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PhraseRecognitionSystem_InvokeErrorEvent(SpeechError errorCode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref errorCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhraseRecognitionSystem.NativeMethodInfoPtr_PhraseRecognitionSystem_InvokeErrorEvent_Private_Static_Void_SpeechError_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001721 RID: 5921 RVA: 0x000599CC File Offset: 0x00057BCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500353, XrefRangeEnd = 500356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PhraseRecognitionSystem_InvokeStatusChangedEvent(SpeechSystemStatus status)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref status;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhraseRecognitionSystem.NativeMethodInfoPtr_PhraseRecognitionSystem_InvokeStatusChangedEvent_Private_Static_Void_SpeechSystemStatus_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001722 RID: 5922 RVA: 0x0000C5CA File Offset: 0x0000A7CA
		public PhraseRecognitionSystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06001723 RID: 5923 RVA: 0x00059A00 File Offset: 0x00057C00
		// (set) Token: 0x06001724 RID: 5924 RVA: 0x0000C5D3 File Offset: 0x0000A7D3
		public unsafe static PhraseRecognitionSystem.ErrorDelegate OnError
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PhraseRecognitionSystem.NativeFieldInfoPtr_OnError, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhraseRecognitionSystem.ErrorDelegate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PhraseRecognitionSystem.NativeFieldInfoPtr_OnError, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06001725 RID: 5925 RVA: 0x00059A28 File Offset: 0x00057C28
		// (set) Token: 0x06001726 RID: 5926 RVA: 0x0000C5E5 File Offset: 0x0000A7E5
		public unsafe static PhraseRecognitionSystem.StatusDelegate OnStatusChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PhraseRecognitionSystem.NativeFieldInfoPtr_OnStatusChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhraseRecognitionSystem.StatusDelegate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PhraseRecognitionSystem.NativeFieldInfoPtr_OnStatusChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400120C RID: 4620
		private static readonly IntPtr NativeFieldInfoPtr_OnError;

		// Token: 0x0400120D RID: 4621
		private static readonly IntPtr NativeFieldInfoPtr_OnStatusChanged;

		// Token: 0x0400120E RID: 4622
		private static readonly IntPtr NativeMethodInfoPtr_PhraseRecognitionSystem_InvokeErrorEvent_Private_Static_Void_SpeechError_0;

		// Token: 0x0400120F RID: 4623
		private static readonly IntPtr NativeMethodInfoPtr_PhraseRecognitionSystem_InvokeStatusChangedEvent_Private_Static_Void_SpeechSystemStatus_0;

		// Token: 0x02000890 RID: 2192
		public sealed class ErrorDelegate : MulticastDelegate
		{
			// Token: 0x06002F28 RID: 12072 RVA: 0x0007CADC File Offset: 0x0007ACDC
			// Note: this type is marked as 'beforefieldinit'.
			static ErrorDelegate()
			{
				Il2CppClassPointerStore<PhraseRecognitionSystem.ErrorDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhraseRecognitionSystem>.NativeClassPtr, "ErrorDelegate");
				PhraseRecognitionSystem.ErrorDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognitionSystem.ErrorDelegate>.NativeClassPtr, 100665351);
				PhraseRecognitionSystem.ErrorDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_SpeechError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognitionSystem.ErrorDelegate>.NativeClassPtr, 100665352);
				PhraseRecognitionSystem.ErrorDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_SpeechError_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognitionSystem.ErrorDelegate>.NativeClassPtr, 100665353);
				PhraseRecognitionSystem.ErrorDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognitionSystem.ErrorDelegate>.NativeClassPtr, 100665354);
			}

			// Token: 0x06002F29 RID: 12073 RVA: 0x0007CB50 File Offset: 0x0007AD50
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ErrorDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhraseRecognitionSystem.ErrorDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhraseRecognitionSystem.ErrorDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F2A RID: 12074 RVA: 0x0007CBAC File Offset: 0x0007ADAC
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 500329, RefRangeEnd = 500342, XrefRangeStart = 500329, XrefRangeEnd = 500329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(SpeechError errorCode)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref errorCode;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhraseRecognitionSystem.ErrorDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_SpeechError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F2B RID: 12075 RVA: 0x0007CBEC File Offset: 0x0007ADEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500342, XrefRangeEnd = 500346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(SpeechError errorCode, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref errorCode;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhraseRecognitionSystem.ErrorDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_SpeechError_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06002F2C RID: 12076 RVA: 0x0007CC5C File Offset: 0x0007AE5C
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhraseRecognitionSystem.ErrorDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F2D RID: 12077 RVA: 0x00013934 File Offset: 0x00011B34
			public ErrorDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002F2E RID: 12078 RVA: 0x0001393D File Offset: 0x00011B3D
			public static implicit operator PhraseRecognitionSystem.ErrorDelegate(Action<SpeechError> A_0)
			{
				return DelegateSupport.ConvertDelegate<PhraseRecognitionSystem.ErrorDelegate>(A_0);
			}

			// Token: 0x06002F2F RID: 12079 RVA: 0x00013945 File Offset: 0x00011B45
			public static PhraseRecognitionSystem.ErrorDelegate operator +(PhraseRecognitionSystem.ErrorDelegate A_0, PhraseRecognitionSystem.ErrorDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<PhraseRecognitionSystem.ErrorDelegate>();
			}

			// Token: 0x06002F30 RID: 12080 RVA: 0x00013953 File Offset: 0x00011B53
			public static PhraseRecognitionSystem.ErrorDelegate operator -(PhraseRecognitionSystem.ErrorDelegate A_0, PhraseRecognitionSystem.ErrorDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<PhraseRecognitionSystem.ErrorDelegate>();
				}
				return delegate2;
			}

			// Token: 0x04001F4C RID: 8012
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001F4D RID: 8013
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_SpeechError_0;

			// Token: 0x04001F4E RID: 8014
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_SpeechError_AsyncCallback_Object_0;

			// Token: 0x04001F4F RID: 8015
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000891 RID: 2193
		public sealed class StatusDelegate : MulticastDelegate
		{
			// Token: 0x06002F31 RID: 12081 RVA: 0x0007CCA0 File Offset: 0x0007AEA0
			// Note: this type is marked as 'beforefieldinit'.
			static StatusDelegate()
			{
				Il2CppClassPointerStore<PhraseRecognitionSystem.StatusDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhraseRecognitionSystem>.NativeClassPtr, "StatusDelegate");
				PhraseRecognitionSystem.StatusDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognitionSystem.StatusDelegate>.NativeClassPtr, 100665355);
				PhraseRecognitionSystem.StatusDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_SpeechSystemStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognitionSystem.StatusDelegate>.NativeClassPtr, 100665356);
				PhraseRecognitionSystem.StatusDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_SpeechSystemStatus_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognitionSystem.StatusDelegate>.NativeClassPtr, 100665357);
				PhraseRecognitionSystem.StatusDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognitionSystem.StatusDelegate>.NativeClassPtr, 100665358);
			}

			// Token: 0x06002F32 RID: 12082 RVA: 0x0007CD14 File Offset: 0x0007AF14
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StatusDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhraseRecognitionSystem.StatusDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhraseRecognitionSystem.StatusDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F33 RID: 12083 RVA: 0x0007CD70 File Offset: 0x0007AF70
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 500329, RefRangeEnd = 500342, XrefRangeStart = 500329, XrefRangeEnd = 500342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(SpeechSystemStatus status)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref status;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhraseRecognitionSystem.StatusDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_SpeechSystemStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F34 RID: 12084 RVA: 0x0007CDB0 File Offset: 0x0007AFB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500346, XrefRangeEnd = 500350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(SpeechSystemStatus status, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref status;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhraseRecognitionSystem.StatusDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_SpeechSystemStatus_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06002F35 RID: 12085 RVA: 0x0007CE20 File Offset: 0x0007B020
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhraseRecognitionSystem.StatusDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F36 RID: 12086 RVA: 0x00013964 File Offset: 0x00011B64
			public StatusDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002F37 RID: 12087 RVA: 0x0001396D File Offset: 0x00011B6D
			public static implicit operator PhraseRecognitionSystem.StatusDelegate(Action<SpeechSystemStatus> A_0)
			{
				return DelegateSupport.ConvertDelegate<PhraseRecognitionSystem.StatusDelegate>(A_0);
			}

			// Token: 0x06002F38 RID: 12088 RVA: 0x00013975 File Offset: 0x00011B75
			public static PhraseRecognitionSystem.StatusDelegate operator +(PhraseRecognitionSystem.StatusDelegate A_0, PhraseRecognitionSystem.StatusDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<PhraseRecognitionSystem.StatusDelegate>();
			}

			// Token: 0x06002F39 RID: 12089 RVA: 0x00013983 File Offset: 0x00011B83
			public static PhraseRecognitionSystem.StatusDelegate operator -(PhraseRecognitionSystem.StatusDelegate A_0, PhraseRecognitionSystem.StatusDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<PhraseRecognitionSystem.StatusDelegate>();
				}
				return delegate2;
			}

			// Token: 0x04001F50 RID: 8016
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001F51 RID: 8017
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_SpeechSystemStatus_0;

			// Token: 0x04001F52 RID: 8018
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_SpeechSystemStatus_AsyncCallback_Object_0;

			// Token: 0x04001F53 RID: 8019
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
