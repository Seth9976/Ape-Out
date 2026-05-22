using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Il2CppRewired.Utils.Interfaces
{
	// Token: 0x020000F5 RID: 245
	public class IKeyedData<TKey> : Il2CppObjectBase
	{
		// Token: 0x060018FF RID: 6399 RVA: 0x0008E974 File Offset: 0x0008CB74
		// Note: this type is marked as 'beforefieldinit'.
		static IKeyedData()
		{
			Il2CppClassPointerStore<IKeyedData<TKey>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Interfaces", "IKeyedData`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)) })).TypeHandle.value);
			IKeyedData<TKey>.NativeMethodInfoPtr_TryGetValue_Public_Abstract_Virtual_New_Boolean_TKey_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IKeyedData<TKey>>.NativeClassPtr, 100669366);
			IKeyedData<TKey>.NativeMethodInfoPtr_TrySetValue_Public_Abstract_Virtual_New_Boolean_TKey_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IKeyedData<TKey>>.NativeClassPtr, 100669367);
		}

		// Token: 0x06001900 RID: 6400 RVA: 0x0008EA00 File Offset: 0x0008CC00
		[CallerCount(0)]
		public unsafe virtual bool TryGetValue<T>(TKey key, out T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref TKey ptr4;
				if (!typeof(TKey).IsValueType)
				{
					TKey tkey = key;
					if (!(tkey is string))
					{
						ref TKey ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(tkey as string);
					}
				}
				else
				{
					ptr4 = ref key;
				}
				*ptr2 = ref ptr4;
			}
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr5 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IKeyedData<T>.MethodInfoStoreGeneric_TryGetValue_Public_Abstract_Virtual_New_Boolean_TKey_byref_T_0.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06001901 RID: 6401 RVA: 0x0008EAF4 File Offset: 0x0008CCF4
		[CallerCount(0)]
		public unsafe virtual bool TrySetValue<T>(TKey key, T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref TKey ptr4;
				if (!typeof(TKey).IsValueType)
				{
					TKey tkey = key;
					if (!(tkey is string))
					{
						ref TKey ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(tkey as string);
					}
				}
				else
				{
					ptr4 = ref key;
				}
				*ptr2 = ref ptr4;
			}
			IntPtr* ptr5 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T ptr7;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				if (!(t is string))
				{
					ref T ptr6 = (ptr7 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
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
					ptr7 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr7 = ref value;
			}
			*ptr5 = ref ptr7;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IKeyedData<T>.MethodInfoStoreGeneric_TrySetValue_Public_Abstract_Virtual_New_Boolean_TKey_T_0.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001902 RID: 6402 RVA: 0x0000A264 File Offset: 0x00008464
		public IKeyedData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040015CC RID: 5580
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Abstract_Virtual_New_Boolean_TKey_byref_T_0;

		// Token: 0x040015CD RID: 5581
		private static readonly IntPtr NativeMethodInfoPtr_TrySetValue_Public_Abstract_Virtual_New_Boolean_TKey_T_0;

		// Token: 0x02000324 RID: 804
		private sealed class MethodInfoStoreGeneric_TryGetValue_Public_Abstract_Virtual_New_Boolean_TKey_byref_T_0
		{
			// Token: 0x0400387E RID: 14462
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IKeyedData<T>.NativeMethodInfoPtr_TryGetValue_Public_Abstract_Virtual_New_Boolean_TKey_byref_T_0, Il2CppClassPointerStore<IKeyedData<T>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000325 RID: 805
		private sealed class MethodInfoStoreGeneric_TrySetValue_Public_Abstract_Virtual_New_Boolean_TKey_T_0
		{
			// Token: 0x0400387F RID: 14463
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IKeyedData<T>.NativeMethodInfoPtr_TrySetValue_Public_Abstract_Virtual_New_Boolean_TKey_T_0, Il2CppClassPointerStore<IKeyedData<T>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
