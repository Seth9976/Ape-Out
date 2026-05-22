using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x0200033E RID: 830
	[Serializable]
	public sealed class SafeSerializationManager : Object
	{
		// Token: 0x0600366F RID: 13935 RVA: 0x0010B1E8 File Offset: 0x001093E8
		// Note: this type is marked as 'beforefieldinit'.
		static SafeSerializationManager()
		{
			Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "SafeSerializationManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr);
			SafeSerializationManager.NativeFieldInfoPtr_m_serializedStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr, "m_serializedStates");
			SafeSerializationManager.NativeFieldInfoPtr_m_savedSerializationInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr, "m_savedSerializationInfo");
			SafeSerializationManager.NativeFieldInfoPtr_m_realObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr, "m_realObject");
			SafeSerializationManager.NativeFieldInfoPtr_m_realType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr, "m_realType");
			SafeSerializationManager.NativeFieldInfoPtr_SerializeObjectState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr, "SerializeObjectState");
			SafeSerializationManager.NativeFieldInfoPtr_RealTypeSerializationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr, "RealTypeSerializationName");
			SafeSerializationManager.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr, 100671759);
			SafeSerializationManager.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr, 100671760);
			SafeSerializationManager.NativeMethodInfoPtr_get_IsActive_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr, 100671761);
			SafeSerializationManager.NativeMethodInfoPtr_CompleteSerialization_Internal_Void_Object_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr, 100671762);
			SafeSerializationManager.NativeMethodInfoPtr_CompleteDeserialization_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr, 100671763);
			SafeSerializationManager.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr, 100671764);
			SafeSerializationManager.NativeMethodInfoPtr_System_Runtime_Serialization_IObjectReference_GetRealObject_Private_Virtual_Final_New_Object_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr, 100671765);
			SafeSerializationManager.NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr, 100671766);
		}

		// Token: 0x06003670 RID: 13936 RVA: 0x0010B330 File Offset: 0x00109530
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeSerializationManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeSerializationManager.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003671 RID: 13937 RVA: 0x0010B36C File Offset: 0x0010956C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214309, XrefRangeEnd = 214326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeSerializationManager(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeSerializationManager.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D1D RID: 3357
		// (get) Token: 0x06003672 RID: 13938 RVA: 0x0010B3D0 File Offset: 0x001095D0
		public unsafe bool IsActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeSerializationManager.NativeMethodInfoPtr_get_IsActive_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003673 RID: 13939 RVA: 0x0010B40C File Offset: 0x0010960C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 214355, RefRangeEnd = 214356, XrefRangeStart = 214326, XrefRangeEnd = 214355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteSerialization(Object serializedObject, SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializedObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeSerializationManager.NativeMethodInfoPtr_CompleteSerialization_Internal_Void_Object_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003674 RID: 13940 RVA: 0x0010B478 File Offset: 0x00109678
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 214380, RefRangeEnd = 214381, XrefRangeStart = 214356, XrefRangeEnd = 214380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteDeserialization(Object deserializedObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(deserializedObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeSerializationManager.NativeMethodInfoPtr_CompleteDeserialization_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003675 RID: 13941 RVA: 0x0010B4BC File Offset: 0x001096BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214381, XrefRangeEnd = 214390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeSerializationManager.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003676 RID: 13942 RVA: 0x0010B518 File Offset: 0x00109718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214390, XrefRangeEnd = 214427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object System_Runtime_Serialization_IObjectReference_GetRealObject(StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeSerializationManager.NativeMethodInfoPtr_System_Runtime_Serialization_IObjectReference_GetRealObject_Private_Virtual_Final_New_Object_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003677 RID: 13943 RVA: 0x0010B570 File Offset: 0x00109770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214427, XrefRangeEnd = 214433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserialized(StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeSerializationManager.NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003678 RID: 13944 RVA: 0x000134A9 File Offset: 0x000116A9
		public SafeSerializationManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D17 RID: 3351
		// (get) Token: 0x06003679 RID: 13945 RVA: 0x0010B5B8 File Offset: 0x001097B8
		// (set) Token: 0x0600367A RID: 13946 RVA: 0x000134B2 File Offset: 0x000116B2
		public unsafe IList<Object> m_serializedStates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSerializationManager.NativeFieldInfoPtr_m_serializedStates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSerializationManager.NativeFieldInfoPtr_m_serializedStates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D18 RID: 3352
		// (get) Token: 0x0600367B RID: 13947 RVA: 0x0010B5E8 File Offset: 0x001097E8
		// (set) Token: 0x0600367C RID: 13948 RVA: 0x000134D1 File Offset: 0x000116D1
		public unsafe SerializationInfo m_savedSerializationInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSerializationManager.NativeFieldInfoPtr_m_savedSerializationInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializationInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSerializationManager.NativeFieldInfoPtr_m_savedSerializationInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D19 RID: 3353
		// (get) Token: 0x0600367D RID: 13949 RVA: 0x0010B618 File Offset: 0x00109818
		// (set) Token: 0x0600367E RID: 13950 RVA: 0x000134F0 File Offset: 0x000116F0
		public unsafe Object m_realObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSerializationManager.NativeFieldInfoPtr_m_realObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSerializationManager.NativeFieldInfoPtr_m_realObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D1A RID: 3354
		// (get) Token: 0x0600367F RID: 13951 RVA: 0x0010B648 File Offset: 0x00109848
		// (set) Token: 0x06003680 RID: 13952 RVA: 0x0001350F File Offset: 0x0001170F
		public unsafe RuntimeType m_realType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSerializationManager.NativeFieldInfoPtr_m_realType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSerializationManager.NativeFieldInfoPtr_m_realType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D1B RID: 3355
		// (get) Token: 0x06003681 RID: 13953 RVA: 0x0010B678 File Offset: 0x00109878
		// (set) Token: 0x06003682 RID: 13954 RVA: 0x0001352E File Offset: 0x0001172E
		public unsafe EventHandler<SafeSerializationEventArgs> SerializeObjectState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSerializationManager.NativeFieldInfoPtr_SerializeObjectState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<SafeSerializationEventArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSerializationManager.NativeFieldInfoPtr_SerializeObjectState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D1C RID: 3356
		// (get) Token: 0x06003683 RID: 13955 RVA: 0x0010B6A8 File Offset: 0x001098A8
		// (set) Token: 0x06003684 RID: 13956 RVA: 0x0001354D File Offset: 0x0001174D
		public unsafe static string RealTypeSerializationName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SafeSerializationManager.NativeFieldInfoPtr_RealTypeSerializationName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SafeSerializationManager.NativeFieldInfoPtr_RealTypeSerializationName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002DF0 RID: 11760
		private static readonly IntPtr NativeFieldInfoPtr_m_serializedStates;

		// Token: 0x04002DF1 RID: 11761
		private static readonly IntPtr NativeFieldInfoPtr_m_savedSerializationInfo;

		// Token: 0x04002DF2 RID: 11762
		private static readonly IntPtr NativeFieldInfoPtr_m_realObject;

		// Token: 0x04002DF3 RID: 11763
		private static readonly IntPtr NativeFieldInfoPtr_m_realType;

		// Token: 0x04002DF4 RID: 11764
		private static readonly IntPtr NativeFieldInfoPtr_SerializeObjectState;

		// Token: 0x04002DF5 RID: 11765
		private static readonly IntPtr NativeFieldInfoPtr_RealTypeSerializationName;

		// Token: 0x04002DF6 RID: 11766
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002DF7 RID: 11767
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04002DF8 RID: 11768
		private static readonly IntPtr NativeMethodInfoPtr_get_IsActive_Internal_get_Boolean_0;

		// Token: 0x04002DF9 RID: 11769
		private static readonly IntPtr NativeMethodInfoPtr_CompleteSerialization_Internal_Void_Object_SerializationInfo_StreamingContext_0;

		// Token: 0x04002DFA RID: 11770
		private static readonly IntPtr NativeMethodInfoPtr_CompleteDeserialization_Internal_Void_Object_0;

		// Token: 0x04002DFB RID: 11771
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04002DFC RID: 11772
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_IObjectReference_GetRealObject_Private_Virtual_Final_New_Object_StreamingContext_0;

		// Token: 0x04002DFD RID: 11773
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0;
	}
}
