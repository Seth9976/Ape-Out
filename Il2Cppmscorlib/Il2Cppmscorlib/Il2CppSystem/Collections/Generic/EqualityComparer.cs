using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x0200049F RID: 1183
	[Serializable]
	public class EqualityComparer<T> : Object
	{
		// Token: 0x060047D4 RID: 18388 RVA: 0x0014B9A0 File Offset: 0x00149BA0
		// Note: this type is marked as 'beforefieldinit'.
		static EqualityComparer()
		{
			Il2CppClassPointerStore<EqualityComparer<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "EqualityComparer`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EqualityComparer<T>>.NativeClassPtr);
			EqualityComparer<T>.NativeFieldInfoPtr_defaultComparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqualityComparer<T>>.NativeClassPtr, "defaultComparer");
			EqualityComparer<T>.NativeMethodInfoPtr_get_Default_Public_Static_get_EqualityComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparer<T>>.NativeClassPtr, 100674031);
			EqualityComparer<T>.NativeMethodInfoPtr_CreateComparer_Private_Static_EqualityComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparer<T>>.NativeClassPtr, 100674032);
			EqualityComparer<T>.NativeMethodInfoPtr_Equals_Public_Abstract_Virtual_New_Boolean_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparer<T>>.NativeClassPtr, 100674033);
			EqualityComparer<T>.NativeMethodInfoPtr_GetHashCode_Public_Abstract_Virtual_New_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparer<T>>.NativeClassPtr, 100674034);
			EqualityComparer<T>.NativeMethodInfoPtr_IndexOf_Internal_Virtual_New_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparer<T>>.NativeClassPtr, 100674035);
			EqualityComparer<T>.NativeMethodInfoPtr_LastIndexOf_Internal_Virtual_New_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparer<T>>.NativeClassPtr, 100674036);
			EqualityComparer<T>.NativeMethodInfoPtr_System_Collections_IEqualityComparer_GetHashCode_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparer<T>>.NativeClassPtr, 100674037);
			EqualityComparer<T>.NativeMethodInfoPtr_System_Collections_IEqualityComparer_Equals_Private_Virtual_Final_New_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparer<T>>.NativeClassPtr, 100674038);
			EqualityComparer<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparer<T>>.NativeClassPtr, 100674039);
		}

		// Token: 0x17001255 RID: 4693
		// (get) Token: 0x060047D5 RID: 18389 RVA: 0x0014BAD4 File Offset: 0x00149CD4
		public unsafe static EqualityComparer<T> Default
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparer<T>.NativeMethodInfoPtr_get_Default_Public_Static_get_EqualityComparer_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EqualityComparer<T>>(intPtr3) : null;
			}
		}

		// Token: 0x060047D6 RID: 18390 RVA: 0x0014BB08 File Offset: 0x00149D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231959, XrefRangeEnd = 232077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EqualityComparer<T> CreateComparer()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparer<T>.NativeMethodInfoPtr_CreateComparer_Private_Static_EqualityComparer_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EqualityComparer<T>>(intPtr3) : null;
		}

		// Token: 0x060047D7 RID: 18391 RVA: 0x0014BB3C File Offset: 0x00149D3C
		[CallerCount(0)]
		public unsafe virtual bool Equals(T x, T y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = x;
					if (!(t is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref x;
				}
				*ptr2 = ref ptr4;
			}
			IntPtr* ptr5 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T ptr7;
			if (!typeof(T).IsValueType)
			{
				T t2 = y;
				if (!(t2 is string))
				{
					ref T ptr6 = (ptr7 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
					if ((ref ptr6) != null)
					{
						ptr7 = ref ptr6;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr6)))
						{
							ptr7 = IL2CPP.il2cpp_object_unbox(ref ptr6);
						}
					}
				}
				else
				{
					ptr7 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
				}
			}
			else
			{
				ptr7 = ref y;
			}
			*ptr5 = ref ptr7;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EqualityComparer<T>.NativeMethodInfoPtr_Equals_Public_Abstract_Virtual_New_Boolean_T_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047D8 RID: 18392 RVA: 0x0014BC3C File Offset: 0x00149E3C
		[CallerCount(0)]
		public unsafe virtual int GetHashCode(T obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = obj;
					if (!(t is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref obj;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EqualityComparer<T>.NativeMethodInfoPtr_GetHashCode_Public_Abstract_Virtual_New_Int32_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060047D9 RID: 18393 RVA: 0x0014BCE0 File Offset: 0x00149EE0
		[CallerCount(0)]
		public unsafe virtual int IndexOf(Il2CppArrayBase<T> array, T value, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				if (!(t is string))
				{
					ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
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
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr4 = ref value;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EqualityComparer<T>.NativeMethodInfoPtr_IndexOf_Internal_Virtual_New_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047DA RID: 18394 RVA: 0x0014BDB4 File Offset: 0x00149FB4
		[CallerCount(0)]
		public unsafe virtual int LastIndexOf(Il2CppArrayBase<T> array, T value, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				if (!(t is string))
				{
					ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
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
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr4 = ref value;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EqualityComparer<T>.NativeMethodInfoPtr_LastIndexOf_Internal_Virtual_New_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047DB RID: 18395 RVA: 0x0014BE88 File Offset: 0x0014A088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232077, XrefRangeEnd = 232080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int System_Collections_IEqualityComparer_GetHashCode(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparer<T>.NativeMethodInfoPtr_System_Collections_IEqualityComparer_GetHashCode_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060047DC RID: 18396 RVA: 0x0014BED8 File Offset: 0x0014A0D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232080, XrefRangeEnd = 232086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool System_Collections_IEqualityComparer_Equals(Object x, Object y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparer<T>.NativeMethodInfoPtr_System_Collections_IEqualityComparer_Equals_Private_Virtual_Final_New_Boolean_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047DD RID: 18397 RVA: 0x0014BF38 File Offset: 0x0014A138
		[CallerCount(0)]
		public unsafe EqualityComparer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EqualityComparer<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparer<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047DE RID: 18398 RVA: 0x0001B028 File Offset: 0x00019228
		public EqualityComparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001254 RID: 4692
		// (get) Token: 0x060047DF RID: 18399 RVA: 0x0014BF74 File Offset: 0x0014A174
		// (set) Token: 0x060047E0 RID: 18400 RVA: 0x0001B031 File Offset: 0x00019231
		public unsafe static EqualityComparer<T> defaultComparer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EqualityComparer<T>.NativeFieldInfoPtr_defaultComparer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EqualityComparer<T>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EqualityComparer<T>.NativeFieldInfoPtr_defaultComparer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003A50 RID: 14928
		private static readonly IntPtr NativeFieldInfoPtr_defaultComparer;

		// Token: 0x04003A51 RID: 14929
		private static readonly IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_EqualityComparer_1_T_0;

		// Token: 0x04003A52 RID: 14930
		private static readonly IntPtr NativeMethodInfoPtr_CreateComparer_Private_Static_EqualityComparer_1_T_0;

		// Token: 0x04003A53 RID: 14931
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Abstract_Virtual_New_Boolean_T_T_0;

		// Token: 0x04003A54 RID: 14932
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Abstract_Virtual_New_Int32_T_0;

		// Token: 0x04003A55 RID: 14933
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Internal_Virtual_New_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0;

		// Token: 0x04003A56 RID: 14934
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Internal_Virtual_New_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0;

		// Token: 0x04003A57 RID: 14935
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEqualityComparer_GetHashCode_Private_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04003A58 RID: 14936
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEqualityComparer_Equals_Private_Virtual_Final_New_Boolean_Object_Object_0;

		// Token: 0x04003A59 RID: 14937
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
