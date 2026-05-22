using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x0200050D RID: 1293
	public class TraceLoggingTypeInfo<DataType> : TraceLoggingTypeInfo
	{
		// Token: 0x06004C1D RID: 19485 RVA: 0x0015FA00 File Offset: 0x0015DC00
		// Note: this type is marked as 'beforefieldinit'.
		static TraceLoggingTypeInfo()
		{
			Il2CppClassPointerStore<TraceLoggingTypeInfo<DataType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "TraceLoggingTypeInfo`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DataType>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TraceLoggingTypeInfo<DataType>>.NativeClassPtr);
			TraceLoggingTypeInfo<DataType>.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingTypeInfo<DataType>>.NativeClassPtr, "instance");
			TraceLoggingTypeInfo<DataType>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingTypeInfo<DataType>>.NativeClassPtr, 100674686);
			TraceLoggingTypeInfo<DataType>.NativeMethodInfoPtr__ctor_Protected_Void_String_EventLevel_EventOpcode_EventKeywords_EventTags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingTypeInfo<DataType>>.NativeClassPtr, 100674687);
			TraceLoggingTypeInfo<DataType>.NativeMethodInfoPtr_get_Instance_Public_Static_get_TraceLoggingTypeInfo_1_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingTypeInfo<DataType>>.NativeClassPtr, 100674688);
			TraceLoggingTypeInfo<DataType>.NativeMethodInfoPtr_WriteData_Public_Abstract_Virtual_New_Void_TraceLoggingDataCollector_byref_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingTypeInfo<DataType>>.NativeClassPtr, 100674689);
			TraceLoggingTypeInfo<DataType>.NativeMethodInfoPtr_WriteObjectData_Public_Virtual_Void_TraceLoggingDataCollector_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingTypeInfo<DataType>>.NativeClassPtr, 100674690);
			TraceLoggingTypeInfo<DataType>.NativeMethodInfoPtr_GetInstance_Internal_Static_TraceLoggingTypeInfo_1_DataType_List_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingTypeInfo<DataType>>.NativeClassPtr, 100674691);
			TraceLoggingTypeInfo<DataType>.NativeMethodInfoPtr_InitInstance_Private_Static_TraceLoggingTypeInfo_1_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingTypeInfo<DataType>>.NativeClassPtr, 100674692);
		}

		// Token: 0x06004C1E RID: 19486 RVA: 0x0015FB0C File Offset: 0x0015DD0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240376, XrefRangeEnd = 240382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TraceLoggingTypeInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TraceLoggingTypeInfo<DataType>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingTypeInfo<DataType>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C1F RID: 19487 RVA: 0x0015FB48 File Offset: 0x0015DD48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240382, XrefRangeEnd = 240387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TraceLoggingTypeInfo(string name, EventLevel level, EventOpcode opcode, EventKeywords keywords, EventTags tags)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TraceLoggingTypeInfo<DataType>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opcode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keywords;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingTypeInfo<DataType>.NativeMethodInfoPtr__ctor_Protected_Void_String_EventLevel_EventOpcode_EventKeywords_EventTags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001316 RID: 4886
		// (get) Token: 0x06004C20 RID: 19488 RVA: 0x0015FBCC File Offset: 0x0015DDCC
		public unsafe static TraceLoggingTypeInfo<DataType> Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240387, XrefRangeEnd = 240391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingTypeInfo<DataType>.NativeMethodInfoPtr_get_Instance_Public_Static_get_TraceLoggingTypeInfo_1_DataType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TraceLoggingTypeInfo<DataType>>(intPtr3) : null;
			}
		}

		// Token: 0x06004C21 RID: 19489 RVA: 0x0015FC00 File Offset: 0x0015DE00
		[CallerCount(0)]
		public unsafe virtual void WriteData(TraceLoggingDataCollector collector, ref DataType value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collector);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TraceLoggingTypeInfo<DataType>.NativeMethodInfoPtr_WriteData_Public_Abstract_Virtual_New_Void_TraceLoggingDataCollector_byref_DataType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<DataType>(intPtr4, false, false));
		}

		// Token: 0x06004C22 RID: 19490 RVA: 0x0015FC78 File Offset: 0x0015DE78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240391, XrefRangeEnd = 240393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteObjectData(TraceLoggingDataCollector collector, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collector);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TraceLoggingTypeInfo<DataType>.NativeMethodInfoPtr_WriteObjectData_Public_Virtual_Void_TraceLoggingDataCollector_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C23 RID: 19491 RVA: 0x0015FCD8 File Offset: 0x0015DED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240393, XrefRangeEnd = 240408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TraceLoggingTypeInfo<DataType> GetInstance(List<Type> recursionCheck)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(recursionCheck);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingTypeInfo<DataType>.NativeMethodInfoPtr_GetInstance_Internal_Static_TraceLoggingTypeInfo_1_DataType_List_1_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TraceLoggingTypeInfo<DataType>>(intPtr3) : null;
			}
		}

		// Token: 0x06004C24 RID: 19492 RVA: 0x0015FD1C File Offset: 0x0015DF1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240408, XrefRangeEnd = 240427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TraceLoggingTypeInfo<DataType> InitInstance()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingTypeInfo<DataType>.NativeMethodInfoPtr_InitInstance_Private_Static_TraceLoggingTypeInfo_1_DataType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TraceLoggingTypeInfo<DataType>>(intPtr3) : null;
		}

		// Token: 0x06004C25 RID: 19493 RVA: 0x0001C429 File Offset: 0x0001A629
		public TraceLoggingTypeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001315 RID: 4885
		// (get) Token: 0x06004C26 RID: 19494 RVA: 0x0015FD50 File Offset: 0x0015DF50
		// (set) Token: 0x06004C27 RID: 19495 RVA: 0x0001C432 File Offset: 0x0001A632
		public unsafe static TraceLoggingTypeInfo<DataType> instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TraceLoggingTypeInfo<DataType>.NativeFieldInfoPtr_instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TraceLoggingTypeInfo<DataType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TraceLoggingTypeInfo<DataType>.NativeFieldInfoPtr_instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003D78 RID: 15736
		private static readonly IntPtr NativeFieldInfoPtr_instance;

		// Token: 0x04003D79 RID: 15737
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04003D7A RID: 15738
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_String_EventLevel_EventOpcode_EventKeywords_EventTags_0;

		// Token: 0x04003D7B RID: 15739
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_TraceLoggingTypeInfo_1_DataType_0;

		// Token: 0x04003D7C RID: 15740
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Abstract_Virtual_New_Void_TraceLoggingDataCollector_byref_DataType_0;

		// Token: 0x04003D7D RID: 15741
		private static readonly IntPtr NativeMethodInfoPtr_WriteObjectData_Public_Virtual_Void_TraceLoggingDataCollector_Object_0;

		// Token: 0x04003D7E RID: 15742
		private static readonly IntPtr NativeMethodInfoPtr_GetInstance_Internal_Static_TraceLoggingTypeInfo_1_DataType_List_1_Type_0;

		// Token: 0x04003D7F RID: 15743
		private static readonly IntPtr NativeMethodInfoPtr_InitInstance_Private_Static_TraceLoggingTypeInfo_1_DataType_0;
	}
}
