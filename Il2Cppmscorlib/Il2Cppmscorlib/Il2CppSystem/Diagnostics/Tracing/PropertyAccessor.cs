using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004D3 RID: 1235
	public class PropertyAccessor<ContainerType> : Object
	{
		// Token: 0x060049D6 RID: 18902 RVA: 0x00155528 File Offset: 0x00153728
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyAccessor()
		{
			Il2CppClassPointerStore<PropertyAccessor<ContainerType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "PropertyAccessor`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ContainerType>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyAccessor<ContainerType>>.NativeClassPtr);
			PropertyAccessor<ContainerType>.NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_TraceLoggingDataCollector_byref_ContainerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyAccessor<ContainerType>>.NativeClassPtr, 100674325);
			PropertyAccessor<ContainerType>.NativeMethodInfoPtr_GetData_Public_Abstract_Virtual_New_Object_ContainerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyAccessor<ContainerType>>.NativeClassPtr, 100674326);
			PropertyAccessor<ContainerType>.NativeMethodInfoPtr_Create_Public_Static_PropertyAccessor_1_ContainerType_PropertyAnalysis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyAccessor<ContainerType>>.NativeClassPtr, 100674327);
			PropertyAccessor<ContainerType>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyAccessor<ContainerType>>.NativeClassPtr, 100674328);
		}

		// Token: 0x060049D7 RID: 18903 RVA: 0x001555E4 File Offset: 0x001537E4
		[CallerCount(0)]
		public unsafe virtual void Write(TraceLoggingDataCollector collector, ref ContainerType value)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyAccessor<ContainerType>.NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_TraceLoggingDataCollector_byref_ContainerType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<ContainerType>(intPtr4, false, false));
		}

		// Token: 0x060049D8 RID: 18904 RVA: 0x0015565C File Offset: 0x0015385C
		[CallerCount(0)]
		public unsafe virtual Object GetData(ContainerType value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref ContainerType ptr4;
				if (!typeof(ContainerType).IsValueType)
				{
					ContainerType containerType = value;
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
					ptr4 = ref value;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyAccessor<ContainerType>.NativeMethodInfoPtr_GetData_Public_Abstract_Virtual_New_Object_ContainerType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060049D9 RID: 18905 RVA: 0x00155704 File Offset: 0x00153904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233823, XrefRangeEnd = 233851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertyAccessor<ContainerType> Create(PropertyAnalysis property)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyAccessor<ContainerType>.NativeMethodInfoPtr_Create_Public_Static_PropertyAccessor_1_ContainerType_PropertyAnalysis_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyAccessor<ContainerType>>(intPtr3) : null;
			}
		}

		// Token: 0x060049DA RID: 18906 RVA: 0x00155748 File Offset: 0x00153948
		[CallerCount(0)]
		public unsafe PropertyAccessor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyAccessor<ContainerType>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyAccessor<ContainerType>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049DB RID: 18907 RVA: 0x0001BAB8 File Offset: 0x00019CB8
		public PropertyAccessor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003BC1 RID: 15297
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_TraceLoggingDataCollector_byref_ContainerType_0;

		// Token: 0x04003BC2 RID: 15298
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_Abstract_Virtual_New_Object_ContainerType_0;

		// Token: 0x04003BC3 RID: 15299
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_PropertyAccessor_1_ContainerType_PropertyAnalysis_0;

		// Token: 0x04003BC4 RID: 15300
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
