using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004C7 RID: 1223
	public static class EnumHelper<UnderlyingType> : Object
	{
		// Token: 0x06004960 RID: 18784 RVA: 0x00153A48 File Offset: 0x00151C48
		// Note: this type is marked as 'beforefieldinit'.
		static EnumHelper()
		{
			Il2CppClassPointerStore<EnumHelper<UnderlyingType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "EnumHelper`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<UnderlyingType>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumHelper<UnderlyingType>>.NativeClassPtr);
			EnumHelper<UnderlyingType>.NativeFieldInfoPtr_IdentityInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumHelper<UnderlyingType>>.NativeClassPtr, "IdentityInfo");
			EnumHelper<UnderlyingType>.NativeMethodInfoPtr_Cast_Public_Static_UnderlyingType_ValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumHelper<UnderlyingType>>.NativeClassPtr, 100674266);
		}

		// Token: 0x06004961 RID: 18785 RVA: 0x00153ADC File Offset: 0x00151CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233644, XrefRangeEnd = 233649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnderlyingType Cast<ValueType>(ValueType value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref ValueType ptr4;
				if (!typeof(ValueType).IsValueType)
				{
					ValueType valueType = value;
					if (!(valueType is string))
					{
						ref ValueType ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(valueType as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(valueType as string);
					}
				}
				else
				{
					ptr4 = ref value;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumHelper<ValueType>.MethodInfoStoreGeneric_Cast_Public_Static_UnderlyingType_ValueType_0.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<UnderlyingType>(intPtr, false, true);
			}
		}

		// Token: 0x06004962 RID: 18786 RVA: 0x0001B75C File Offset: 0x0001995C
		public EnumHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001295 RID: 4757
		// (get) Token: 0x06004963 RID: 18787 RVA: 0x00153B68 File Offset: 0x00151D68
		// (set) Token: 0x06004964 RID: 18788 RVA: 0x0001B765 File Offset: 0x00019965
		public unsafe static MethodInfo IdentityInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EnumHelper<UnderlyingType>.NativeFieldInfoPtr_IdentityInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EnumHelper<UnderlyingType>.NativeFieldInfoPtr_IdentityInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003B63 RID: 15203
		private static readonly IntPtr NativeFieldInfoPtr_IdentityInfo;

		// Token: 0x04003B64 RID: 15204
		private static readonly IntPtr NativeMethodInfoPtr_Cast_Public_Static_UnderlyingType_ValueType_0;

		// Token: 0x02000674 RID: 1652
		public sealed class Transformer<ValueType> : MulticastDelegate
		{
			// Token: 0x06005856 RID: 22614 RVA: 0x00189644 File Offset: 0x00187844
			// Note: this type is marked as 'beforefieldinit'.
			static Transformer()
			{
				Il2CppClassPointerStore<EnumHelper<UnderlyingType>.Transformer<ValueType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnumHelper<UnderlyingType>>.NativeClassPtr, "Transformer`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<UnderlyingType>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ValueType>.NativeClassPtr))
				})).TypeHandle.value);
				EnumHelper<UnderlyingType>.Transformer<ValueType>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumHelper<UnderlyingType>.Transformer<ValueType>>.NativeClassPtr, 100674268);
				EnumHelper<UnderlyingType>.Transformer<ValueType>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_UnderlyingType_ValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumHelper<UnderlyingType>.Transformer<ValueType>>.NativeClassPtr, 100674269);
				EnumHelper<UnderlyingType>.Transformer<ValueType>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ValueType_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumHelper<UnderlyingType>.Transformer<ValueType>>.NativeClassPtr, 100674270);
				EnumHelper<UnderlyingType>.Transformer<ValueType>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_UnderlyingType_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumHelper<UnderlyingType>.Transformer<ValueType>>.NativeClassPtr, 100674271);
			}

			// Token: 0x06005857 RID: 22615 RVA: 0x00189704 File Offset: 0x00187904
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Transformer(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumHelper<UnderlyingType>.Transformer<ValueType>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumHelper<UnderlyingType>.Transformer<ValueType>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005858 RID: 22616 RVA: 0x00189760 File Offset: 0x00187960
			[CallerCount(0)]
			public unsafe UnderlyingType Invoke(ValueType value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					IntPtr* ptr2 = ptr;
					ref ValueType ptr4;
					if (!typeof(ValueType).IsValueType)
					{
						ValueType valueType = value;
						if (!(valueType is string))
						{
							ref ValueType ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(valueType as Il2CppObjectBase));
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
							ptr4 = IL2CPP.ManagedStringToIl2Cpp(valueType as string);
						}
					}
					else
					{
						ptr4 = ref value;
					}
					*ptr2 = ref ptr4;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumHelper<UnderlyingType>.Transformer<ValueType>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_UnderlyingType_ValueType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<UnderlyingType>(intPtr, false, true);
				}
			}

			// Token: 0x06005859 RID: 22617 RVA: 0x001897F8 File Offset: 0x001879F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233640, XrefRangeEnd = 233644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(ValueType value, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					IntPtr* ptr2 = ptr;
					ref ValueType ptr4;
					if (!typeof(ValueType).IsValueType)
					{
						ValueType valueType = value;
						if (!(valueType is string))
						{
							ref ValueType ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(valueType as Il2CppObjectBase));
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
							ptr4 = IL2CPP.ManagedStringToIl2Cpp(valueType as string);
						}
					}
					else
					{
						ptr4 = ref value;
					}
					*ptr2 = ref ptr4;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumHelper<UnderlyingType>.Transformer<ValueType>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ValueType_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600585A RID: 22618 RVA: 0x001898B8 File Offset: 0x00187AB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UnderlyingType EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumHelper<UnderlyingType>.Transformer<ValueType>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_UnderlyingType_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<UnderlyingType>(intPtr, false, true);
				}
			}

			// Token: 0x0600585B RID: 22619 RVA: 0x00021A98 File Offset: 0x0001FC98
			public Transformer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600585C RID: 22620 RVA: 0x00021AA1 File Offset: 0x0001FCA1
			public static implicit operator EnumHelper<UnderlyingType>.Transformer<ValueType>(Func<ValueType, UnderlyingType> A_0)
			{
				return DelegateSupport.ConvertDelegate<EnumHelper<UnderlyingType>.Transformer<ValueType>>(A_0);
			}

			// Token: 0x0600585D RID: 22621 RVA: 0x00021AA9 File Offset: 0x0001FCA9
			public static EnumHelper<UnderlyingType>.Transformer<ValueType>operator +(EnumHelper<UnderlyingType>.Transformer<ValueType> A_0, EnumHelper<UnderlyingType>.Transformer<ValueType> A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<EnumHelper<UnderlyingType>.Transformer<ValueType>>();
			}

			// Token: 0x0600585E RID: 22622 RVA: 0x00021AB7 File Offset: 0x0001FCB7
			public static EnumHelper<UnderlyingType>.Transformer<ValueType>operator -(EnumHelper<UnderlyingType>.Transformer<ValueType> A_0, EnumHelper<UnderlyingType>.Transformer<ValueType> A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<EnumHelper<UnderlyingType>.Transformer<ValueType>>();
				}
				return delegate2;
			}

			// Token: 0x040046DA RID: 18138
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040046DB RID: 18139
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_UnderlyingType_ValueType_0;

			// Token: 0x040046DC RID: 18140
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ValueType_AsyncCallback_Object_0;

			// Token: 0x040046DD RID: 18141
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_UnderlyingType_IAsyncResult_0;
		}

		// Token: 0x02000675 RID: 1653
		public static class Caster<ValueType> : Object
		{
			// Token: 0x0600585F RID: 22623 RVA: 0x00189904 File Offset: 0x00187B04
			// Note: this type is marked as 'beforefieldinit'.
			static Caster()
			{
				Il2CppClassPointerStore<EnumHelper<UnderlyingType>.Caster<ValueType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnumHelper<UnderlyingType>>.NativeClassPtr, "Caster`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<UnderlyingType>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ValueType>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumHelper<UnderlyingType>.Caster<ValueType>>.NativeClassPtr);
				EnumHelper<UnderlyingType>.Caster<ValueType>.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumHelper<UnderlyingType>.Caster<ValueType>>.NativeClassPtr, "Instance");
			}

			// Token: 0x06005860 RID: 22624 RVA: 0x00021AC8 File Offset: 0x0001FCC8
			public Caster(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170016DF RID: 5855
			// (get) Token: 0x06005861 RID: 22625 RVA: 0x00189990 File Offset: 0x00187B90
			// (set) Token: 0x06005862 RID: 22626 RVA: 0x00021AD1 File Offset: 0x0001FCD1
			public unsafe static EnumHelper<UnderlyingType>.Transformer<ValueType> Instance
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EnumHelper<UnderlyingType>.Caster<ValueType>.NativeFieldInfoPtr_Instance, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EnumHelper<UnderlyingType>.Transformer<ValueType>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EnumHelper<UnderlyingType>.Caster<ValueType>.NativeFieldInfoPtr_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040046DE RID: 18142
			private static readonly IntPtr NativeFieldInfoPtr_Instance;
		}

		// Token: 0x02000676 RID: 1654
		private sealed class MethodInfoStoreGeneric_Cast_Public_Static_UnderlyingType_ValueType_0
		{
			// Token: 0x040046DF RID: 18143
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(EnumHelper<ValueType>.NativeMethodInfoPtr_Cast_Public_Static_UnderlyingType_ValueType_0, Il2CppClassPointerStore<EnumHelper<ValueType>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ValueType>.NativeClassPtr)) }))));
		}
	}
}
