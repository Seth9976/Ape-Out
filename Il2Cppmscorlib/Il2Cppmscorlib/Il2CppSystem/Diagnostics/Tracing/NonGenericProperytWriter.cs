using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004D4 RID: 1236
	public class NonGenericProperytWriter<ContainerType> : PropertyAccessor<ContainerType>
	{
		// Token: 0x060049DC RID: 18908 RVA: 0x00155784 File Offset: 0x00153984
		// Note: this type is marked as 'beforefieldinit'.
		static NonGenericProperytWriter()
		{
			Il2CppClassPointerStore<NonGenericProperytWriter<ContainerType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "NonGenericProperytWriter`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ContainerType>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NonGenericProperytWriter<ContainerType>>.NativeClassPtr);
			NonGenericProperytWriter<ContainerType>.NativeFieldInfoPtr_typeInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NonGenericProperytWriter<ContainerType>>.NativeClassPtr, "typeInfo");
			NonGenericProperytWriter<ContainerType>.NativeFieldInfoPtr_getterInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NonGenericProperytWriter<ContainerType>>.NativeClassPtr, "getterInfo");
			NonGenericProperytWriter<ContainerType>.NativeMethodInfoPtr__ctor_Public_Void_PropertyAnalysis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NonGenericProperytWriter<ContainerType>>.NativeClassPtr, 100674329);
			NonGenericProperytWriter<ContainerType>.NativeMethodInfoPtr_Write_Public_Virtual_Void_TraceLoggingDataCollector_byref_ContainerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NonGenericProperytWriter<ContainerType>>.NativeClassPtr, 100674330);
			NonGenericProperytWriter<ContainerType>.NativeMethodInfoPtr_GetData_Public_Virtual_Object_ContainerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NonGenericProperytWriter<ContainerType>>.NativeClassPtr, 100674331);
		}

		// Token: 0x060049DD RID: 18909 RVA: 0x00155854 File Offset: 0x00153A54
		[CallerCount(0)]
		public unsafe NonGenericProperytWriter(PropertyAnalysis property)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NonGenericProperytWriter<ContainerType>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NonGenericProperytWriter<ContainerType>.NativeMethodInfoPtr__ctor_Public_Void_PropertyAnalysis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060049DE RID: 18910 RVA: 0x001558A0 File Offset: 0x00153AA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233851, XrefRangeEnd = 233854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(TraceLoggingDataCollector collector, ref ContainerType container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collector);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(container);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NonGenericProperytWriter<ContainerType>.NativeMethodInfoPtr_Write_Public_Virtual_Void_TraceLoggingDataCollector_byref_ContainerType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			container = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<ContainerType>(intPtr4, false, false));
		}

		// Token: 0x060049DF RID: 18911 RVA: 0x00155918 File Offset: 0x00153B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233854, XrefRangeEnd = 233856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object GetData(ContainerType container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref ContainerType ptr4;
				if (!typeof(ContainerType).IsValueType)
				{
					ContainerType containerType = container;
					if (!(containerType is string))
					{
						ref ContainerType ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(containerType as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(containerType as string);
					}
				}
				else
				{
					ptr4 = ref container;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NonGenericProperytWriter<ContainerType>.NativeMethodInfoPtr_GetData_Public_Virtual_Object_ContainerType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060049E0 RID: 18912 RVA: 0x0001BAC1 File Offset: 0x00019CC1
		public NonGenericProperytWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170012BF RID: 4799
		// (get) Token: 0x060049E1 RID: 18913 RVA: 0x001559C0 File Offset: 0x00153BC0
		// (set) Token: 0x060049E2 RID: 18914 RVA: 0x0001BACA File Offset: 0x00019CCA
		public unsafe TraceLoggingTypeInfo typeInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NonGenericProperytWriter<ContainerType>.NativeFieldInfoPtr_typeInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TraceLoggingTypeInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NonGenericProperytWriter<ContainerType>.NativeFieldInfoPtr_typeInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012C0 RID: 4800
		// (get) Token: 0x060049E3 RID: 18915 RVA: 0x001559F0 File Offset: 0x00153BF0
		// (set) Token: 0x060049E4 RID: 18916 RVA: 0x0001BAE9 File Offset: 0x00019CE9
		public unsafe MethodInfo getterInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NonGenericProperytWriter<ContainerType>.NativeFieldInfoPtr_getterInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NonGenericProperytWriter<ContainerType>.NativeFieldInfoPtr_getterInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003BC5 RID: 15301
		private static readonly IntPtr NativeFieldInfoPtr_typeInfo;

		// Token: 0x04003BC6 RID: 15302
		private static readonly IntPtr NativeFieldInfoPtr_getterInfo;

		// Token: 0x04003BC7 RID: 15303
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PropertyAnalysis_0;

		// Token: 0x04003BC8 RID: 15304
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_TraceLoggingDataCollector_byref_ContainerType_0;

		// Token: 0x04003BC9 RID: 15305
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_Virtual_Object_ContainerType_0;
	}
}
