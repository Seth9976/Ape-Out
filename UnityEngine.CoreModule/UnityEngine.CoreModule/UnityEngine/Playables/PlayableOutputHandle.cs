using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Playables
{
	// Token: 0x0200018E RID: 398
	[StructLayout(2)]
	public struct PlayableOutputHandle
	{
		// Token: 0x06001E79 RID: 7801 RVA: 0x0006FECC File Offset: 0x0006E0CC
		// Note: this type is marked as 'beforefieldinit'.
		static PlayableOutputHandle()
		{
			Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "PlayableOutputHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr);
			PlayableOutputHandle.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, "m_Handle");
			PlayableOutputHandle.NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, "m_Version");
			PlayableOutputHandle.NativeFieldInfoPtr_m_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, "m_Null");
			PlayableOutputHandle.NativeMethodInfoPtr_get_Null_Public_Static_get_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100666066);
			PlayableOutputHandle.NativeMethodInfoPtr_IsPlayableOutputOfType_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100666067);
			PlayableOutputHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100666068);
			PlayableOutputHandle.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PlayableOutputHandle_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100666069);
			PlayableOutputHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100666070);
			PlayableOutputHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100666071);
			PlayableOutputHandle.NativeMethodInfoPtr_CompareVersion_Internal_Static_Boolean_PlayableOutputHandle_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100666072);
			PlayableOutputHandle.NativeMethodInfoPtr_IsValid_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100666073);
			PlayableOutputHandle.NativeMethodInfoPtr_GetPlayableOutputType_Internal_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100666074);
			PlayableOutputHandle.NativeMethodInfoPtr_SetReferenceObject_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100666075);
			PlayableOutputHandle.NativeMethodInfoPtr_SetUserData_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100666076);
			PlayableOutputHandle.NativeMethodInfoPtr_GetSourcePlayable_Internal_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100666077);
			PlayableOutputHandle.NativeMethodInfoPtr_SetSourcePlayable_Internal_Void_PlayableHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100666078);
			PlayableOutputHandle.NativeMethodInfoPtr_GetSourceOutputPort_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100666079);
			PlayableOutputHandle.NativeMethodInfoPtr_SetWeight_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100666080);
			PlayableOutputHandle.NativeMethodInfoPtr_PushNotification_Internal_Void_PlayableHandle_INotification_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100666081);
			PlayableOutputHandle.NativeMethodInfoPtr_AddNotificationReceiver_Internal_Void_INotificationReceiver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100666082);
			PlayableOutputHandle.NativeMethodInfoPtr_IsValid_Injected_Private_Static_Boolean_byref_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100666084);
			PlayableOutputHandle.NativeMethodInfoPtr_GetPlayableOutputType_Injected_Private_Static_Type_byref_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100666085);
			PlayableOutputHandle.NativeMethodInfoPtr_SetReferenceObject_Injected_Private_Static_Void_byref_PlayableOutputHandle_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100666086);
			PlayableOutputHandle.NativeMethodInfoPtr_SetUserData_Injected_Private_Static_Void_byref_PlayableOutputHandle_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100666087);
			PlayableOutputHandle.NativeMethodInfoPtr_GetSourcePlayable_Injected_Private_Static_Void_byref_PlayableOutputHandle_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100666088);
			PlayableOutputHandle.NativeMethodInfoPtr_SetSourcePlayable_Injected_Private_Static_Void_byref_PlayableOutputHandle_byref_PlayableHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100666089);
			PlayableOutputHandle.NativeMethodInfoPtr_GetSourceOutputPort_Injected_Private_Static_Int32_byref_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100666090);
			PlayableOutputHandle.NativeMethodInfoPtr_SetWeight_Injected_Private_Static_Void_byref_PlayableOutputHandle_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100666091);
			PlayableOutputHandle.NativeMethodInfoPtr_PushNotification_Injected_Private_Static_Void_byref_PlayableOutputHandle_byref_PlayableHandle_INotification_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100666092);
			PlayableOutputHandle.NativeMethodInfoPtr_AddNotificationReceiver_Injected_Private_Static_Void_byref_PlayableOutputHandle_INotificationReceiver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100666093);
			PlayableOutputHandle.IsNull_InjectedDelegateField = IL2CPP.ResolveICall<PlayableOutputHandle.IsNull_InjectedDelegate>("UnityEngine.Playables.PlayableOutputHandle::IsNull_Injected");
			PlayableOutputHandle.GetReferenceObject_InjectedDelegateField = IL2CPP.ResolveICall<PlayableOutputHandle.GetReferenceObject_InjectedDelegate>("UnityEngine.Playables.PlayableOutputHandle::GetReferenceObject_Injected");
			PlayableOutputHandle.GetUserData_InjectedDelegateField = IL2CPP.ResolveICall<PlayableOutputHandle.GetUserData_InjectedDelegate>("UnityEngine.Playables.PlayableOutputHandle::GetUserData_Injected");
			PlayableOutputHandle.GetWeight_InjectedDelegateField = IL2CPP.ResolveICall<PlayableOutputHandle.GetWeight_InjectedDelegate>("UnityEngine.Playables.PlayableOutputHandle::GetWeight_Injected");
			PlayableOutputHandle.GetNotificationReceivers_InjectedDelegateField = IL2CPP.ResolveICall<PlayableOutputHandle.GetNotificationReceivers_InjectedDelegate>("UnityEngine.Playables.PlayableOutputHandle::GetNotificationReceivers_Injected");
			PlayableOutputHandle.RemoveNotificationReceiver_InjectedDelegateField = IL2CPP.ResolveICall<PlayableOutputHandle.RemoveNotificationReceiver_InjectedDelegate>("UnityEngine.Playables.PlayableOutputHandle::RemoveNotificationReceiver_Injected");
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06001E7A RID: 7802 RVA: 0x000701B0 File Offset: 0x0006E3B0
		public unsafe static PlayableOutputHandle Null
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504061, XrefRangeEnd = 504065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_get_Null_Public_Static_get_PlayableOutputHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E7B RID: 7803 RVA: 0x000701E0 File Offset: 0x0006E3E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504065, XrefRangeEnd = 504070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPlayableOutputOfType<T>()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.MethodInfoStoreGeneric_IsPlayableOutputOfType_Internal_Boolean_0<T>.Pointer, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E7C RID: 7804 RVA: 0x00070210 File Offset: 0x0006E410
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E7D RID: 7805 RVA: 0x00070240 File Offset: 0x0006E440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504070, XrefRangeEnd = 504073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(PlayableOutputHandle lhs, PlayableOutputHandle rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PlayableOutputHandle_PlayableOutputHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E7E RID: 7806 RVA: 0x0007028C File Offset: 0x0006E48C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504073, XrefRangeEnd = 504078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E7F RID: 7807 RVA: 0x000702D0 File Offset: 0x0006E4D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504078, XrefRangeEnd = 504081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(PlayableOutputHandle other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableOutputHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E80 RID: 7808 RVA: 0x00070310 File Offset: 0x0006E510
		[CallerCount(0)]
		public unsafe static bool CompareVersion(PlayableOutputHandle lhs, PlayableOutputHandle rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_CompareVersion_Internal_Static_Boolean_PlayableOutputHandle_PlayableOutputHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E81 RID: 7809 RVA: 0x0007035C File Offset: 0x0006E55C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 504088, RefRangeEnd = 504091, XrefRangeStart = 504081, XrefRangeEnd = 504088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValid()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_IsValid_Internal_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E82 RID: 7810 RVA: 0x0007038C File Offset: 0x0006E58C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 504098, RefRangeEnd = 504099, XrefRangeStart = 504091, XrefRangeEnd = 504098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type GetPlayableOutputType()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_GetPlayableOutputType_Internal_Type_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06001E83 RID: 7811 RVA: 0x000703C0 File Offset: 0x0006E5C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504099, XrefRangeEnd = 504106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetReferenceObject(Object target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_SetReferenceObject_Internal_Void_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E84 RID: 7812 RVA: 0x000703F8 File Offset: 0x0006E5F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504106, XrefRangeEnd = 504113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUserData(Object target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_SetUserData_Internal_Void_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E85 RID: 7813 RVA: 0x00070430 File Offset: 0x0006E630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504113, XrefRangeEnd = 504118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayableHandle GetSourcePlayable()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_GetSourcePlayable_Internal_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E86 RID: 7814 RVA: 0x00070460 File Offset: 0x0006E660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504118, XrefRangeEnd = 504123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSourcePlayable(PlayableHandle target, int port)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref target;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref port;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_SetSourcePlayable_Internal_Void_PlayableHandle_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E87 RID: 7815 RVA: 0x000704A0 File Offset: 0x0006E6A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504123, XrefRangeEnd = 504130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetSourceOutputPort()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_GetSourceOutputPort_Internal_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E88 RID: 7816 RVA: 0x000704D0 File Offset: 0x0006E6D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504130, XrefRangeEnd = 504137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWeight(float weight)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref weight;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_SetWeight_Internal_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E89 RID: 7817 RVA: 0x00070504 File Offset: 0x0006E704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504137, XrefRangeEnd = 504142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushNotification(PlayableHandle origin, INotification notification, Object context)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(notification);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_PushNotification_Internal_Void_PlayableHandle_INotification_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E8A RID: 7818 RVA: 0x0007055C File Offset: 0x0006E75C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504142, XrefRangeEnd = 504151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddNotificationReceiver(INotificationReceiver receiver)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(receiver);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_AddNotificationReceiver_Internal_Void_INotificationReceiver_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E8B RID: 7819 RVA: 0x00070594 File Offset: 0x0006E794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504151, XrefRangeEnd = 504155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValid_Injected(ref PlayableOutputHandle _unity_self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_IsValid_Injected_Private_Static_Boolean_byref_PlayableOutputHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E8C RID: 7820 RVA: 0x000705D4 File Offset: 0x0006E7D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504155, XrefRangeEnd = 504159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetPlayableOutputType_Injected(ref PlayableOutputHandle _unity_self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_GetPlayableOutputType_Injected_Private_Static_Type_byref_PlayableOutputHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06001E8D RID: 7821 RVA: 0x00070614 File Offset: 0x0006E814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504159, XrefRangeEnd = 504163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetReferenceObject_Injected(ref PlayableOutputHandle _unity_self, Object target)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_SetReferenceObject_Injected_Private_Static_Void_byref_PlayableOutputHandle_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E8E RID: 7822 RVA: 0x00070658 File Offset: 0x0006E858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504163, XrefRangeEnd = 504167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetUserData_Injected(ref PlayableOutputHandle _unity_self, Object target)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_SetUserData_Injected_Private_Static_Void_byref_PlayableOutputHandle_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E8F RID: 7823 RVA: 0x0007069C File Offset: 0x0006E89C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504167, XrefRangeEnd = 504171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetSourcePlayable_Injected(ref PlayableOutputHandle _unity_self, out PlayableHandle ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_GetSourcePlayable_Injected_Private_Static_Void_byref_PlayableOutputHandle_byref_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E90 RID: 7824 RVA: 0x000706DC File Offset: 0x0006E8DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504171, XrefRangeEnd = 504175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetSourcePlayable_Injected(ref PlayableOutputHandle _unity_self, ref PlayableHandle target, int port)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &target;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref port;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_SetSourcePlayable_Injected_Private_Static_Void_byref_PlayableOutputHandle_byref_PlayableHandle_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E91 RID: 7825 RVA: 0x0007072C File Offset: 0x0006E92C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504175, XrefRangeEnd = 504179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetSourceOutputPort_Injected(ref PlayableOutputHandle _unity_self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_GetSourceOutputPort_Injected_Private_Static_Int32_byref_PlayableOutputHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E92 RID: 7826 RVA: 0x0007076C File Offset: 0x0006E96C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504179, XrefRangeEnd = 504183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetWeight_Injected(ref PlayableOutputHandle _unity_self, float weight)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_SetWeight_Injected_Private_Static_Void_byref_PlayableOutputHandle_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E93 RID: 7827 RVA: 0x000707AC File Offset: 0x0006E9AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504183, XrefRangeEnd = 504187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PushNotification_Injected(ref PlayableOutputHandle _unity_self, ref PlayableHandle origin, INotification notification, Object context)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &origin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(notification);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_PushNotification_Injected_Private_Static_Void_byref_PlayableOutputHandle_byref_PlayableHandle_INotification_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E94 RID: 7828 RVA: 0x00070810 File Offset: 0x0006EA10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504187, XrefRangeEnd = 504191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddNotificationReceiver_Injected(ref PlayableOutputHandle _unity_self, INotificationReceiver receiver)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(receiver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_AddNotificationReceiver_Injected_Private_Static_Void_byref_PlayableOutputHandle_INotificationReceiver_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E95 RID: 7829 RVA: 0x0000FFB6 File Offset: 0x0000E1B6
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06001E96 RID: 7830 RVA: 0x00070854 File Offset: 0x0006EA54
		// (set) Token: 0x06001E97 RID: 7831 RVA: 0x0000FFC8 File Offset: 0x0000E1C8
		public unsafe static PlayableOutputHandle m_Null
		{
			get
			{
				PlayableOutputHandle playableOutputHandle;
				IL2CPP.il2cpp_field_static_get_value(PlayableOutputHandle.NativeFieldInfoPtr_m_Null, (void*)(&playableOutputHandle));
				return playableOutputHandle;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayableOutputHandle.NativeFieldInfoPtr_m_Null, (void*)(&value));
			}
		}

		// Token: 0x06001E98 RID: 7832 RVA: 0x00070870 File Offset: 0x0006EA70
		public static bool operator !=(PlayableOutputHandle lhs, PlayableOutputHandle rhs)
		{
			return !PlayableOutputHandle.CompareVersion(lhs, rhs);
		}

		// Token: 0x06001E99 RID: 7833 RVA: 0x0000FFD6 File Offset: 0x0000E1D6
		public bool IsNull()
		{
			return PlayableOutputHandle.IsNull_Injected(ref this);
		}

		// Token: 0x06001E9A RID: 7834 RVA: 0x0000FFDE File Offset: 0x0000E1DE
		public Object GetReferenceObject()
		{
			return PlayableOutputHandle.GetReferenceObject_Injected(ref this);
		}

		// Token: 0x06001E9B RID: 7835 RVA: 0x0000FFE6 File Offset: 0x0000E1E6
		public Object GetUserData()
		{
			return PlayableOutputHandle.GetUserData_Injected(ref this);
		}

		// Token: 0x06001E9C RID: 7836 RVA: 0x0000FFEE File Offset: 0x0000E1EE
		public float GetWeight()
		{
			return PlayableOutputHandle.GetWeight_Injected(ref this);
		}

		// Token: 0x06001E9D RID: 7837 RVA: 0x0000FFF6 File Offset: 0x0000E1F6
		public Il2CppReferenceArray<INotificationReceiver> GetNotificationReceivers()
		{
			return PlayableOutputHandle.GetNotificationReceivers_Injected(ref this);
		}

		// Token: 0x06001E9E RID: 7838 RVA: 0x0000FFFE File Offset: 0x0000E1FE
		public void RemoveNotificationReceiver(INotificationReceiver receiver)
		{
			PlayableOutputHandle.RemoveNotificationReceiver_Injected(ref this, receiver);
		}

		// Token: 0x06001E9F RID: 7839 RVA: 0x00010007 File Offset: 0x0000E207
		public static bool IsNull_Injected(ref PlayableOutputHandle _unity_self)
		{
			return PlayableOutputHandle.IsNull_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06001EA0 RID: 7840 RVA: 0x0007088C File Offset: 0x0006EA8C
		public static Object GetReferenceObject_Injected(ref PlayableOutputHandle _unity_self)
		{
			IntPtr intPtr = PlayableOutputHandle.GetReferenceObject_InjectedDelegateField(ref _unity_self);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x06001EA1 RID: 7841 RVA: 0x000708B4 File Offset: 0x0006EAB4
		public static Object GetUserData_Injected(ref PlayableOutputHandle _unity_self)
		{
			IntPtr intPtr = PlayableOutputHandle.GetUserData_InjectedDelegateField(ref _unity_self);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x06001EA2 RID: 7842 RVA: 0x00010014 File Offset: 0x0000E214
		public static float GetWeight_Injected(ref PlayableOutputHandle _unity_self)
		{
			return PlayableOutputHandle.GetWeight_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06001EA3 RID: 7843 RVA: 0x000708DC File Offset: 0x0006EADC
		public static Il2CppReferenceArray<INotificationReceiver> GetNotificationReceivers_Injected(ref PlayableOutputHandle _unity_self)
		{
			IntPtr intPtr = PlayableOutputHandle.GetNotificationReceivers_InjectedDelegateField(ref _unity_self);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<INotificationReceiver>>(intPtr2) : null;
		}

		// Token: 0x06001EA4 RID: 7844 RVA: 0x00010021 File Offset: 0x0000E221
		public static void RemoveNotificationReceiver_Injected(ref PlayableOutputHandle _unity_self, INotificationReceiver receiver)
		{
			PlayableOutputHandle.RemoveNotificationReceiver_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(receiver));
		}

		// Token: 0x04001756 RID: 5974
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x04001757 RID: 5975
		private static readonly IntPtr NativeFieldInfoPtr_m_Version;

		// Token: 0x04001758 RID: 5976
		private static readonly IntPtr NativeFieldInfoPtr_m_Null;

		// Token: 0x04001759 RID: 5977
		private static readonly IntPtr NativeMethodInfoPtr_get_Null_Public_Static_get_PlayableOutputHandle_0;

		// Token: 0x0400175A RID: 5978
		private static readonly IntPtr NativeMethodInfoPtr_IsPlayableOutputOfType_Internal_Boolean_0;

		// Token: 0x0400175B RID: 5979
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400175C RID: 5980
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PlayableOutputHandle_PlayableOutputHandle_0;

		// Token: 0x0400175D RID: 5981
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400175E RID: 5982
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableOutputHandle_0;

		// Token: 0x0400175F RID: 5983
		private static readonly IntPtr NativeMethodInfoPtr_CompareVersion_Internal_Static_Boolean_PlayableOutputHandle_PlayableOutputHandle_0;

		// Token: 0x04001760 RID: 5984
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Internal_Boolean_0;

		// Token: 0x04001761 RID: 5985
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayableOutputType_Internal_Type_0;

		// Token: 0x04001762 RID: 5986
		private static readonly IntPtr NativeMethodInfoPtr_SetReferenceObject_Internal_Void_Object_0;

		// Token: 0x04001763 RID: 5987
		private static readonly IntPtr NativeMethodInfoPtr_SetUserData_Internal_Void_Object_0;

		// Token: 0x04001764 RID: 5988
		private static readonly IntPtr NativeMethodInfoPtr_GetSourcePlayable_Internal_PlayableHandle_0;

		// Token: 0x04001765 RID: 5989
		private static readonly IntPtr NativeMethodInfoPtr_SetSourcePlayable_Internal_Void_PlayableHandle_Int32_0;

		// Token: 0x04001766 RID: 5990
		private static readonly IntPtr NativeMethodInfoPtr_GetSourceOutputPort_Internal_Int32_0;

		// Token: 0x04001767 RID: 5991
		private static readonly IntPtr NativeMethodInfoPtr_SetWeight_Internal_Void_Single_0;

		// Token: 0x04001768 RID: 5992
		private static readonly IntPtr NativeMethodInfoPtr_PushNotification_Internal_Void_PlayableHandle_INotification_Object_0;

		// Token: 0x04001769 RID: 5993
		private static readonly IntPtr NativeMethodInfoPtr_AddNotificationReceiver_Internal_Void_INotificationReceiver_0;

		// Token: 0x0400176A RID: 5994
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Injected_Private_Static_Boolean_byref_PlayableOutputHandle_0;

		// Token: 0x0400176B RID: 5995
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayableOutputType_Injected_Private_Static_Type_byref_PlayableOutputHandle_0;

		// Token: 0x0400176C RID: 5996
		private static readonly IntPtr NativeMethodInfoPtr_SetReferenceObject_Injected_Private_Static_Void_byref_PlayableOutputHandle_Object_0;

		// Token: 0x0400176D RID: 5997
		private static readonly IntPtr NativeMethodInfoPtr_SetUserData_Injected_Private_Static_Void_byref_PlayableOutputHandle_Object_0;

		// Token: 0x0400176E RID: 5998
		private static readonly IntPtr NativeMethodInfoPtr_GetSourcePlayable_Injected_Private_Static_Void_byref_PlayableOutputHandle_byref_PlayableHandle_0;

		// Token: 0x0400176F RID: 5999
		private static readonly IntPtr NativeMethodInfoPtr_SetSourcePlayable_Injected_Private_Static_Void_byref_PlayableOutputHandle_byref_PlayableHandle_Int32_0;

		// Token: 0x04001770 RID: 6000
		private static readonly IntPtr NativeMethodInfoPtr_GetSourceOutputPort_Injected_Private_Static_Int32_byref_PlayableOutputHandle_0;

		// Token: 0x04001771 RID: 6001
		private static readonly IntPtr NativeMethodInfoPtr_SetWeight_Injected_Private_Static_Void_byref_PlayableOutputHandle_Single_0;

		// Token: 0x04001772 RID: 6002
		private static readonly IntPtr NativeMethodInfoPtr_PushNotification_Injected_Private_Static_Void_byref_PlayableOutputHandle_byref_PlayableHandle_INotification_Object_0;

		// Token: 0x04001773 RID: 6003
		private static readonly IntPtr NativeMethodInfoPtr_AddNotificationReceiver_Injected_Private_Static_Void_byref_PlayableOutputHandle_INotificationReceiver_0;

		// Token: 0x04001774 RID: 6004
		[FieldOffset(0)]
		public IntPtr m_Handle;

		// Token: 0x04001775 RID: 6005
		[FieldOffset(8)]
		public uint m_Version;

		// Token: 0x04001776 RID: 6006
		private static readonly PlayableOutputHandle.IsNull_InjectedDelegate IsNull_InjectedDelegateField;

		// Token: 0x04001777 RID: 6007
		private static readonly PlayableOutputHandle.GetReferenceObject_InjectedDelegate GetReferenceObject_InjectedDelegateField;

		// Token: 0x04001778 RID: 6008
		private static readonly PlayableOutputHandle.GetUserData_InjectedDelegate GetUserData_InjectedDelegateField;

		// Token: 0x04001779 RID: 6009
		private static readonly PlayableOutputHandle.GetWeight_InjectedDelegate GetWeight_InjectedDelegateField;

		// Token: 0x0400177A RID: 6010
		private static readonly PlayableOutputHandle.GetNotificationReceivers_InjectedDelegate GetNotificationReceivers_InjectedDelegateField;

		// Token: 0x0400177B RID: 6011
		private static readonly PlayableOutputHandle.RemoveNotificationReceiver_InjectedDelegate RemoveNotificationReceiver_InjectedDelegateField;

		// Token: 0x02000A3C RID: 2620
		private sealed class MethodInfoStoreGeneric_IsPlayableOutputOfType_Internal_Boolean_0<T>
		{
			// Token: 0x04001FFF RID: 8191
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableOutputHandle.NativeMethodInfoPtr_IsPlayableOutputOfType_Internal_Boolean_0, Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000A3D RID: 2621
		// (Invoke) Token: 0x060032F1 RID: 13041
		private delegate bool IsNull_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A3E RID: 2622
		// (Invoke) Token: 0x060032F3 RID: 13043
		private delegate IntPtr GetReferenceObject_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A3F RID: 2623
		// (Invoke) Token: 0x060032F5 RID: 13045
		private delegate IntPtr GetUserData_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A40 RID: 2624
		// (Invoke) Token: 0x060032F7 RID: 13047
		private delegate float GetWeight_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A41 RID: 2625
		// (Invoke) Token: 0x060032F9 RID: 13049
		private delegate IntPtr GetNotificationReceivers_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A42 RID: 2626
		// (Invoke) Token: 0x060032FB RID: 13051
		private delegate void RemoveNotificationReceiver_InjectedDelegate(IntPtr _unity_self, IntPtr receiver);
	}
}
