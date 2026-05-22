using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000345 RID: 837
	public class SerializationEvents : Object
	{
		// Token: 0x0600369B RID: 13979 RVA: 0x0010BA28 File Offset: 0x00109C28
		// Note: this type is marked as 'beforefieldinit'.
		static SerializationEvents()
		{
			Il2CppClassPointerStore<SerializationEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "SerializationEvents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializationEvents>.NativeClassPtr);
			SerializationEvents.NativeFieldInfoPtr_m_OnSerializingMethods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationEvents>.NativeClassPtr, "m_OnSerializingMethods");
			SerializationEvents.NativeFieldInfoPtr_m_OnSerializedMethods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationEvents>.NativeClassPtr, "m_OnSerializedMethods");
			SerializationEvents.NativeFieldInfoPtr_m_OnDeserializingMethods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationEvents>.NativeClassPtr, "m_OnDeserializingMethods");
			SerializationEvents.NativeFieldInfoPtr_m_OnDeserializedMethods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationEvents>.NativeClassPtr, "m_OnDeserializedMethods");
			SerializationEvents.NativeMethodInfoPtr_GetMethodsWithAttribute_Private_List_1_MethodInfo_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationEvents>.NativeClassPtr, 100671775);
			SerializationEvents.NativeMethodInfoPtr__ctor_Internal_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationEvents>.NativeClassPtr, 100671776);
			SerializationEvents.NativeMethodInfoPtr_get_HasOnSerializingEvents_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationEvents>.NativeClassPtr, 100671777);
			SerializationEvents.NativeMethodInfoPtr_InvokeOnSerializing_Internal_Void_Object_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationEvents>.NativeClassPtr, 100671778);
			SerializationEvents.NativeMethodInfoPtr_InvokeOnDeserializing_Internal_Void_Object_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationEvents>.NativeClassPtr, 100671779);
			SerializationEvents.NativeMethodInfoPtr_InvokeOnDeserialized_Internal_Void_Object_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationEvents>.NativeClassPtr, 100671780);
			SerializationEvents.NativeMethodInfoPtr_AddOnSerialized_Internal_SerializationEventHandler_Object_SerializationEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationEvents>.NativeClassPtr, 100671781);
			SerializationEvents.NativeMethodInfoPtr_AddOnDeserialized_Internal_SerializationEventHandler_Object_SerializationEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationEvents>.NativeClassPtr, 100671782);
		}

		// Token: 0x0600369C RID: 13980 RVA: 0x0010BB48 File Offset: 0x00109D48
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 214455, RefRangeEnd = 214459, XrefRangeStart = 214433, XrefRangeEnd = 214455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<MethodInfo> GetMethodsWithAttribute(Type attribute, Type t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationEvents.NativeMethodInfoPtr_GetMethodsWithAttribute_Private_List_1_MethodInfo_Type_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<MethodInfo>>(intPtr3) : null;
		}

		// Token: 0x0600369D RID: 13981 RVA: 0x0010BBAC File Offset: 0x00109DAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 214478, RefRangeEnd = 214479, XrefRangeStart = 214459, XrefRangeEnd = 214478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializationEvents(Type t)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializationEvents>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationEvents.NativeMethodInfoPtr__ctor_Internal_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000D24 RID: 3364
		// (get) Token: 0x0600369E RID: 13982 RVA: 0x0010BBF8 File Offset: 0x00109DF8
		public unsafe bool HasOnSerializingEvents
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationEvents.NativeMethodInfoPtr_get_HasOnSerializingEvents_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600369F RID: 13983 RVA: 0x0010BC34 File Offset: 0x00109E34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 214508, RefRangeEnd = 214509, XrefRangeStart = 214479, XrefRangeEnd = 214508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeOnSerializing(Object obj, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationEvents.NativeMethodInfoPtr_InvokeOnSerializing_Internal_Void_Object_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036A0 RID: 13984 RVA: 0x0010BC90 File Offset: 0x00109E90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 214538, RefRangeEnd = 214540, XrefRangeStart = 214509, XrefRangeEnd = 214538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeOnDeserializing(Object obj, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationEvents.NativeMethodInfoPtr_InvokeOnDeserializing_Internal_Void_Object_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036A1 RID: 13985 RVA: 0x0010BCEC File Offset: 0x00109EEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 214569, RefRangeEnd = 214571, XrefRangeStart = 214540, XrefRangeEnd = 214569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeOnDeserialized(Object obj, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationEvents.NativeMethodInfoPtr_InvokeOnDeserialized_Internal_Void_Object_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036A2 RID: 13986 RVA: 0x0010BD48 File Offset: 0x00109F48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 214599, RefRangeEnd = 214601, XrefRangeStart = 214571, XrefRangeEnd = 214599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializationEventHandler AddOnSerialized(Object obj, SerializationEventHandler handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationEvents.NativeMethodInfoPtr_AddOnSerialized_Internal_SerializationEventHandler_Object_SerializationEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializationEventHandler>(intPtr3) : null;
		}

		// Token: 0x060036A3 RID: 13987 RVA: 0x0010BDAC File Offset: 0x00109FAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 214629, RefRangeEnd = 214630, XrefRangeStart = 214601, XrefRangeEnd = 214629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializationEventHandler AddOnDeserialized(Object obj, SerializationEventHandler handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationEvents.NativeMethodInfoPtr_AddOnDeserialized_Internal_SerializationEventHandler_Object_SerializationEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializationEventHandler>(intPtr3) : null;
		}

		// Token: 0x060036A4 RID: 13988 RVA: 0x00013680 File Offset: 0x00011880
		public SerializationEvents(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D20 RID: 3360
		// (get) Token: 0x060036A5 RID: 13989 RVA: 0x0010BE10 File Offset: 0x0010A010
		// (set) Token: 0x060036A6 RID: 13990 RVA: 0x00013689 File Offset: 0x00011889
		public unsafe List<MethodInfo> m_OnSerializingMethods
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationEvents.NativeFieldInfoPtr_m_OnSerializingMethods);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MethodInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationEvents.NativeFieldInfoPtr_m_OnSerializingMethods), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D21 RID: 3361
		// (get) Token: 0x060036A7 RID: 13991 RVA: 0x0010BE40 File Offset: 0x0010A040
		// (set) Token: 0x060036A8 RID: 13992 RVA: 0x000136A8 File Offset: 0x000118A8
		public unsafe List<MethodInfo> m_OnSerializedMethods
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationEvents.NativeFieldInfoPtr_m_OnSerializedMethods);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MethodInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationEvents.NativeFieldInfoPtr_m_OnSerializedMethods), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D22 RID: 3362
		// (get) Token: 0x060036A9 RID: 13993 RVA: 0x0010BE70 File Offset: 0x0010A070
		// (set) Token: 0x060036AA RID: 13994 RVA: 0x000136C7 File Offset: 0x000118C7
		public unsafe List<MethodInfo> m_OnDeserializingMethods
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationEvents.NativeFieldInfoPtr_m_OnDeserializingMethods);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MethodInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationEvents.NativeFieldInfoPtr_m_OnDeserializingMethods), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D23 RID: 3363
		// (get) Token: 0x060036AB RID: 13995 RVA: 0x0010BEA0 File Offset: 0x0010A0A0
		// (set) Token: 0x060036AC RID: 13996 RVA: 0x000136E6 File Offset: 0x000118E6
		public unsafe List<MethodInfo> m_OnDeserializedMethods
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationEvents.NativeFieldInfoPtr_m_OnDeserializedMethods);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MethodInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationEvents.NativeFieldInfoPtr_m_OnDeserializedMethods), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002E07 RID: 11783
		private static readonly IntPtr NativeFieldInfoPtr_m_OnSerializingMethods;

		// Token: 0x04002E08 RID: 11784
		private static readonly IntPtr NativeFieldInfoPtr_m_OnSerializedMethods;

		// Token: 0x04002E09 RID: 11785
		private static readonly IntPtr NativeFieldInfoPtr_m_OnDeserializingMethods;

		// Token: 0x04002E0A RID: 11786
		private static readonly IntPtr NativeFieldInfoPtr_m_OnDeserializedMethods;

		// Token: 0x04002E0B RID: 11787
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodsWithAttribute_Private_List_1_MethodInfo_Type_Type_0;

		// Token: 0x04002E0C RID: 11788
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Type_0;

		// Token: 0x04002E0D RID: 11789
		private static readonly IntPtr NativeMethodInfoPtr_get_HasOnSerializingEvents_Internal_get_Boolean_0;

		// Token: 0x04002E0E RID: 11790
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnSerializing_Internal_Void_Object_StreamingContext_0;

		// Token: 0x04002E0F RID: 11791
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnDeserializing_Internal_Void_Object_StreamingContext_0;

		// Token: 0x04002E10 RID: 11792
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnDeserialized_Internal_Void_Object_StreamingContext_0;

		// Token: 0x04002E11 RID: 11793
		private static readonly IntPtr NativeMethodInfoPtr_AddOnSerialized_Internal_SerializationEventHandler_Object_SerializationEventHandler_0;

		// Token: 0x04002E12 RID: 11794
		private static readonly IntPtr NativeMethodInfoPtr_AddOnDeserialized_Internal_SerializationEventHandler_Object_SerializationEventHandler_0;
	}
}
