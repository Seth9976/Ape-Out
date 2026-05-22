using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004D6 RID: 1238
	public sealed class PropertyAnalysis : Object
	{
		// Token: 0x060049EE RID: 18926 RVA: 0x00155CD0 File Offset: 0x00153ED0
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyAnalysis()
		{
			Il2CppClassPointerStore<PropertyAnalysis>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "PropertyAnalysis");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyAnalysis>.NativeClassPtr);
			PropertyAnalysis.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyAnalysis>.NativeClassPtr, "name");
			PropertyAnalysis.NativeFieldInfoPtr_getterInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyAnalysis>.NativeClassPtr, "getterInfo");
			PropertyAnalysis.NativeFieldInfoPtr_typeInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyAnalysis>.NativeClassPtr, "typeInfo");
			PropertyAnalysis.NativeFieldInfoPtr_fieldAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyAnalysis>.NativeClassPtr, "fieldAttribute");
			PropertyAnalysis.NativeMethodInfoPtr__ctor_Public_Void_String_MethodInfo_TraceLoggingTypeInfo_EventFieldAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyAnalysis>.NativeClassPtr, 100674339);
		}

		// Token: 0x060049EF RID: 18927 RVA: 0x00155D64 File Offset: 0x00153F64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 233875, RefRangeEnd = 233876, XrefRangeStart = 233875, XrefRangeEnd = 233875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyAnalysis(string name, MethodInfo getterInfo, TraceLoggingTypeInfo typeInfo, EventFieldAttribute fieldAttribute)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyAnalysis>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getterInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeInfo);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fieldAttribute);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyAnalysis.NativeMethodInfoPtr__ctor_Public_Void_String_MethodInfo_TraceLoggingTypeInfo_EventFieldAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049F0 RID: 18928 RVA: 0x0001BB4F File Offset: 0x00019D4F
		public PropertyAnalysis(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170012C3 RID: 4803
		// (get) Token: 0x060049F1 RID: 18929 RVA: 0x00155DE8 File Offset: 0x00153FE8
		// (set) Token: 0x060049F2 RID: 18930 RVA: 0x0001BB58 File Offset: 0x00019D58
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyAnalysis.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyAnalysis.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170012C4 RID: 4804
		// (get) Token: 0x060049F3 RID: 18931 RVA: 0x00155E10 File Offset: 0x00154010
		// (set) Token: 0x060049F4 RID: 18932 RVA: 0x0001BB77 File Offset: 0x00019D77
		public unsafe MethodInfo getterInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyAnalysis.NativeFieldInfoPtr_getterInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyAnalysis.NativeFieldInfoPtr_getterInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012C5 RID: 4805
		// (get) Token: 0x060049F5 RID: 18933 RVA: 0x00155E40 File Offset: 0x00154040
		// (set) Token: 0x060049F6 RID: 18934 RVA: 0x0001BB96 File Offset: 0x00019D96
		public unsafe TraceLoggingTypeInfo typeInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyAnalysis.NativeFieldInfoPtr_typeInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TraceLoggingTypeInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyAnalysis.NativeFieldInfoPtr_typeInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012C6 RID: 4806
		// (get) Token: 0x060049F7 RID: 18935 RVA: 0x00155E70 File Offset: 0x00154070
		// (set) Token: 0x060049F8 RID: 18936 RVA: 0x0001BBB5 File Offset: 0x00019DB5
		public unsafe EventFieldAttribute fieldAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyAnalysis.NativeFieldInfoPtr_fieldAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventFieldAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyAnalysis.NativeFieldInfoPtr_fieldAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003BCF RID: 15311
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04003BD0 RID: 15312
		private static readonly IntPtr NativeFieldInfoPtr_getterInfo;

		// Token: 0x04003BD1 RID: 15313
		private static readonly IntPtr NativeFieldInfoPtr_typeInfo;

		// Token: 0x04003BD2 RID: 15314
		private static readonly IntPtr NativeFieldInfoPtr_fieldAttribute;

		// Token: 0x04003BD3 RID: 15315
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_MethodInfo_TraceLoggingTypeInfo_EventFieldAttribute_0;
	}
}
