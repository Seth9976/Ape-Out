using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004D5 RID: 1237
	public class ClassPropertyWriter<ContainerType, ValueType> : PropertyAccessor<ContainerType>
	{
		// Token: 0x060049E5 RID: 18917 RVA: 0x00155A20 File Offset: 0x00153C20
		// Note: this type is marked as 'beforefieldinit'.
		static ClassPropertyWriter()
		{
			Il2CppClassPointerStore<ClassPropertyWriter<ContainerType, ValueType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "ClassPropertyWriter`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ContainerType>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ValueType>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClassPropertyWriter<ContainerType, ValueType>>.NativeClassPtr);
			ClassPropertyWriter<ContainerType, ValueType>.NativeFieldInfoPtr_valueTypeInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClassPropertyWriter<ContainerType, ValueType>>.NativeClassPtr, "valueTypeInfo");
			ClassPropertyWriter<ContainerType, ValueType>.NativeFieldInfoPtr_getter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClassPropertyWriter<ContainerType, ValueType>>.NativeClassPtr, "getter");
			ClassPropertyWriter<ContainerType, ValueType>.NativeMethodInfoPtr__ctor_Public_Void_PropertyAnalysis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassPropertyWriter<ContainerType, ValueType>>.NativeClassPtr, 100674332);
			ClassPropertyWriter<ContainerType, ValueType>.NativeMethodInfoPtr_Write_Public_Virtual_Void_TraceLoggingDataCollector_byref_ContainerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassPropertyWriter<ContainerType, ValueType>>.NativeClassPtr, 100674333);
			ClassPropertyWriter<ContainerType, ValueType>.NativeMethodInfoPtr_GetData_Public_Virtual_Object_ContainerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassPropertyWriter<ContainerType, ValueType>>.NativeClassPtr, 100674334);
		}

		// Token: 0x060049E6 RID: 18918 RVA: 0x00155B04 File Offset: 0x00153D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233860, XrefRangeEnd = 233873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClassPropertyWriter(PropertyAnalysis property)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClassPropertyWriter<ContainerType, ValueType>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassPropertyWriter<ContainerType, ValueType>.NativeMethodInfoPtr__ctor_Public_Void_PropertyAnalysis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060049E7 RID: 18919 RVA: 0x00155B50 File Offset: 0x00153D50
		[CallerCount(0)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClassPropertyWriter<ContainerType, ValueType>.NativeMethodInfoPtr_Write_Public_Virtual_Void_TraceLoggingDataCollector_byref_ContainerType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			container = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<ContainerType>(intPtr4, false, false));
		}

		// Token: 0x060049E8 RID: 18920 RVA: 0x00155BC8 File Offset: 0x00153DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233873, XrefRangeEnd = 233875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClassPropertyWriter<ContainerType, ValueType>.NativeMethodInfoPtr_GetData_Public_Virtual_Object_ContainerType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060049E9 RID: 18921 RVA: 0x0001BB08 File Offset: 0x00019D08
		public ClassPropertyWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170012C1 RID: 4801
		// (get) Token: 0x060049EA RID: 18922 RVA: 0x00155C70 File Offset: 0x00153E70
		// (set) Token: 0x060049EB RID: 18923 RVA: 0x0001BB11 File Offset: 0x00019D11
		public unsafe TraceLoggingTypeInfo<ValueType> valueTypeInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassPropertyWriter<ContainerType, ValueType>.NativeFieldInfoPtr_valueTypeInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TraceLoggingTypeInfo<ValueType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassPropertyWriter<ContainerType, ValueType>.NativeFieldInfoPtr_valueTypeInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012C2 RID: 4802
		// (get) Token: 0x060049EC RID: 18924 RVA: 0x00155CA0 File Offset: 0x00153EA0
		// (set) Token: 0x060049ED RID: 18925 RVA: 0x0001BB30 File Offset: 0x00019D30
		public unsafe ClassPropertyWriter<ContainerType, ValueType>.Getter getter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassPropertyWriter<ContainerType, ValueType>.NativeFieldInfoPtr_getter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClassPropertyWriter<ContainerType, ValueType>.Getter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassPropertyWriter<ContainerType, ValueType>.NativeFieldInfoPtr_getter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003BCA RID: 15306
		private static readonly IntPtr NativeFieldInfoPtr_valueTypeInfo;

		// Token: 0x04003BCB RID: 15307
		private static readonly IntPtr NativeFieldInfoPtr_getter;

		// Token: 0x04003BCC RID: 15308
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PropertyAnalysis_0;

		// Token: 0x04003BCD RID: 15309
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_TraceLoggingDataCollector_byref_ContainerType_0;

		// Token: 0x04003BCE RID: 15310
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_Virtual_Object_ContainerType_0;

		// Token: 0x02000678 RID: 1656
		public sealed class Getter : MulticastDelegate
		{
			// Token: 0x06005874 RID: 22644 RVA: 0x00189D14 File Offset: 0x00187F14
			// Note: this type is marked as 'beforefieldinit'.
			static Getter()
			{
				Il2CppClassPointerStore<ClassPropertyWriter<ContainerType, ValueType>.Getter>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClassPropertyWriter<ContainerType, ValueType>>.NativeClassPtr, "Getter"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ContainerType>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ValueType>.NativeClassPtr))
				})).TypeHandle.value);
				ClassPropertyWriter<ContainerType, ValueType>.Getter.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassPropertyWriter<ContainerType, ValueType>.Getter>.NativeClassPtr, 100674335);
				ClassPropertyWriter<ContainerType, ValueType>.Getter.NativeMethodInfoPtr_Invoke_Public_Virtual_New_ValueType_ContainerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassPropertyWriter<ContainerType, ValueType>.Getter>.NativeClassPtr, 100674336);
				ClassPropertyWriter<ContainerType, ValueType>.Getter.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ContainerType_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassPropertyWriter<ContainerType, ValueType>.Getter>.NativeClassPtr, 100674337);
				ClassPropertyWriter<ContainerType, ValueType>.Getter.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_ValueType_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassPropertyWriter<ContainerType, ValueType>.Getter>.NativeClassPtr, 100674338);
			}

			// Token: 0x06005875 RID: 22645 RVA: 0x00189DD4 File Offset: 0x00187FD4
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Getter(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClassPropertyWriter<ContainerType, ValueType>.Getter>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassPropertyWriter<ContainerType, ValueType>.Getter.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005876 RID: 22646 RVA: 0x00189E30 File Offset: 0x00188030
			[CallerCount(0)]
			public unsafe ValueType Invoke(ContainerType container)
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassPropertyWriter<ContainerType, ValueType>.Getter.NativeMethodInfoPtr_Invoke_Public_Virtual_New_ValueType_ContainerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<ValueType>(intPtr, false, true);
				}
			}

			// Token: 0x06005877 RID: 22647 RVA: 0x00189EC8 File Offset: 0x001880C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233856, XrefRangeEnd = 233860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(ContainerType container, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
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
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassPropertyWriter<ContainerType, ValueType>.Getter.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ContainerType_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06005878 RID: 22648 RVA: 0x00189F88 File Offset: 0x00188188
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueType EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassPropertyWriter<ContainerType, ValueType>.Getter.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_ValueType_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<ValueType>(intPtr, false, true);
				}
			}

			// Token: 0x06005879 RID: 22649 RVA: 0x00021B6F File Offset: 0x0001FD6F
			public Getter(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600587A RID: 22650 RVA: 0x00021B78 File Offset: 0x0001FD78
			public static implicit operator ClassPropertyWriter<ContainerType, ValueType>.Getter(Func<ContainerType, ValueType> A_0)
			{
				return DelegateSupport.ConvertDelegate<ClassPropertyWriter<ContainerType, ValueType>.Getter>(A_0);
			}

			// Token: 0x0600587B RID: 22651 RVA: 0x00021B80 File Offset: 0x0001FD80
			public static ClassPropertyWriter<ContainerType, ValueType>.Getter operator +(ClassPropertyWriter<ContainerType, ValueType>.Getter A_0, ClassPropertyWriter<ContainerType, ValueType>.Getter A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ClassPropertyWriter<ContainerType, ValueType>.Getter>();
			}

			// Token: 0x0600587C RID: 22652 RVA: 0x00021B8E File Offset: 0x0001FD8E
			public static ClassPropertyWriter<ContainerType, ValueType>.Getter operator -(ClassPropertyWriter<ContainerType, ValueType>.Getter A_0, ClassPropertyWriter<ContainerType, ValueType>.Getter A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ClassPropertyWriter<ContainerType, ValueType>.Getter>();
				}
				return delegate2;
			}

			// Token: 0x040046EA RID: 18154
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040046EB RID: 18155
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_ValueType_ContainerType_0;

			// Token: 0x040046EC RID: 18156
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ContainerType_AsyncCallback_Object_0;

			// Token: 0x040046ED RID: 18157
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_ValueType_IAsyncResult_0;
		}
	}
}
