using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2CppTMPro
{
	// Token: 0x0200002C RID: 44
	public static class SetPropertyUtility : global::Il2CppSystem.Object
	{
		// Token: 0x06000520 RID: 1312 RVA: 0x0001BCC4 File Offset: 0x00019EC4
		// Note: this type is marked as 'beforefieldinit'.
		static SetPropertyUtility()
		{
			Il2CppClassPointerStore<SetPropertyUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "SetPropertyUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetPropertyUtility>.NativeClassPtr);
			SetPropertyUtility.NativeMethodInfoPtr_SetColor_Public_Static_Boolean_byref_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPropertyUtility>.NativeClassPtr, 100663951);
			SetPropertyUtility.NativeMethodInfoPtr_SetEquatableStruct_Public_Static_Boolean_byref_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPropertyUtility>.NativeClassPtr, 100663952);
			SetPropertyUtility.NativeMethodInfoPtr_SetStruct_Public_Static_Boolean_byref_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPropertyUtility>.NativeClassPtr, 100663953);
			SetPropertyUtility.NativeMethodInfoPtr_SetClass_Public_Static_Boolean_byref_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPropertyUtility>.NativeClassPtr, 100663954);
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x0001BD44 File Offset: 0x00019F44
		[CallerCount(0)]
		public unsafe static bool SetColor(ref Color currentValue, Color newValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &currentValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetPropertyUtility.NativeMethodInfoPtr_SetColor_Public_Static_Boolean_byref_Color_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x0001BD90 File Offset: 0x00019F90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 456859, XrefRangeEnd = 456861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetEquatableStruct<T>(ref T currentValue, T newValue)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(currentValue);
				ptr2 = &intPtr;
			}
			IntPtr* ptr3 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T ptr5;
			if (!typeof(T).IsValueType)
			{
				T t = newValue;
				if (!(t is string))
				{
					ref T ptr4 = (ptr5 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					if ((ref ptr4) != null)
					{
						ptr5 = ref ptr4;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr4)))
						{
							ptr5 = IL2CPP.il2cpp_object_unbox(ref ptr4);
						}
					}
				}
				else
				{
					ptr5 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr5 = ref newValue;
			}
			*ptr3 = ref ptr5;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SetPropertyUtility.MethodInfoStoreGeneric_SetEquatableStruct_Public_Static_Boolean_byref_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			currentValue = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x0001BE48 File Offset: 0x0001A048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 456861, XrefRangeEnd = 456865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetStruct<T>(ref T currentValue, T newValue) where T : new()
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(currentValue);
				ptr2 = &intPtr;
			}
			IntPtr* ptr3 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T ptr5;
			if (!typeof(T).IsValueType)
			{
				T t = newValue;
				if (!(t is string))
				{
					ref T ptr4 = (ptr5 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					if ((ref ptr4) != null)
					{
						ptr5 = ref ptr4;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr4)))
						{
							ptr5 = IL2CPP.il2cpp_object_unbox(ref ptr4);
						}
					}
				}
				else
				{
					ptr5 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr5 = ref newValue;
			}
			*ptr3 = ref ptr5;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SetPropertyUtility.MethodInfoStoreGeneric_SetStruct_Public_Static_Boolean_byref_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			currentValue = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x0001BF00 File Offset: 0x0001A100
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 456865, RefRangeEnd = 456908, XrefRangeStart = 456865, XrefRangeEnd = 456865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetClass<T>(ref T currentValue, T newValue) where T : class
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(currentValue);
				ptr2 = &intPtr;
			}
			IntPtr* ptr3 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T ptr5;
			if (!typeof(T).IsValueType)
			{
				T t = newValue;
				if (!(t is string))
				{
					ref T ptr4 = (ptr5 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					if ((ref ptr4) != null)
					{
						ptr5 = ref ptr4;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr4)))
						{
							ptr5 = IL2CPP.il2cpp_object_unbox(ref ptr4);
						}
					}
				}
				else
				{
					ptr5 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr5 = ref newValue;
			}
			*ptr3 = ref ptr5;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SetPropertyUtility.MethodInfoStoreGeneric_SetClass_Public_Static_Boolean_byref_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			currentValue = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x000045EF File Offset: 0x000027EF
		public SetPropertyUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003C3 RID: 963
		private static readonly IntPtr NativeMethodInfoPtr_SetColor_Public_Static_Boolean_byref_Color_Color_0;

		// Token: 0x040003C4 RID: 964
		private static readonly IntPtr NativeMethodInfoPtr_SetEquatableStruct_Public_Static_Boolean_byref_T_T_0;

		// Token: 0x040003C5 RID: 965
		private static readonly IntPtr NativeMethodInfoPtr_SetStruct_Public_Static_Boolean_byref_T_T_0;

		// Token: 0x040003C6 RID: 966
		private static readonly IntPtr NativeMethodInfoPtr_SetClass_Public_Static_Boolean_byref_T_T_0;

		// Token: 0x02000097 RID: 151
		private sealed class MethodInfoStoreGeneric_SetEquatableStruct_Public_Static_Boolean_byref_T_T_0<T>
		{
			// Token: 0x04000C27 RID: 3111
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SetPropertyUtility.NativeMethodInfoPtr_SetEquatableStruct_Public_Static_Boolean_byref_T_T_0, Il2CppClassPointerStore<SetPropertyUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000098 RID: 152
		private sealed class MethodInfoStoreGeneric_SetStruct_Public_Static_Boolean_byref_T_T_0<T>
		{
			// Token: 0x04000C28 RID: 3112
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SetPropertyUtility.NativeMethodInfoPtr_SetStruct_Public_Static_Boolean_byref_T_T_0, Il2CppClassPointerStore<SetPropertyUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000099 RID: 153
		private sealed class MethodInfoStoreGeneric_SetClass_Public_Static_Boolean_byref_T_T_0<T>
		{
			// Token: 0x04000C29 RID: 3113
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SetPropertyUtility.NativeMethodInfoPtr_SetClass_Public_Static_Boolean_byref_T_T_0, Il2CppClassPointerStore<SetPropertyUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
