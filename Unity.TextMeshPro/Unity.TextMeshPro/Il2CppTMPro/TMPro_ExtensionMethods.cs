using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2CppTMPro
{
	// Token: 0x02000062 RID: 98
	public static class TMPro_ExtensionMethods : global::Il2CppSystem.Object
	{
		// Token: 0x06000C26 RID: 3110 RVA: 0x000336C8 File Offset: 0x000318C8
		// Note: this type is marked as 'beforefieldinit'.
		static TMPro_ExtensionMethods()
		{
			Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMPro_ExtensionMethods");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr);
			TMPro_ExtensionMethods.NativeMethodInfoPtr_ToIntArray_Public_Static_Il2CppStructArray_1_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100664685);
			TMPro_ExtensionMethods.NativeMethodInfoPtr_ArrayToString_Public_Static_String_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100664686);
			TMPro_ExtensionMethods.NativeMethodInfoPtr_IntToString_Public_Static_String_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100664687);
			TMPro_ExtensionMethods.NativeMethodInfoPtr_UintToString_Internal_Static_String_List_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100664688);
			TMPro_ExtensionMethods.NativeMethodInfoPtr_IntToString_Public_Static_String_Il2CppStructArray_1_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100664689);
			TMPro_ExtensionMethods.NativeMethodInfoPtr_FindInstanceID_Public_Static_Int32_List_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100664690);
			TMPro_ExtensionMethods.NativeMethodInfoPtr_Compare_Public_Static_Boolean_Color32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100664691);
			TMPro_ExtensionMethods.NativeMethodInfoPtr_CompareRGB_Public_Static_Boolean_Color32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100664692);
			TMPro_ExtensionMethods.NativeMethodInfoPtr_Compare_Public_Static_Boolean_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100664693);
			TMPro_ExtensionMethods.NativeMethodInfoPtr_CompareRGB_Public_Static_Boolean_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100664694);
			TMPro_ExtensionMethods.NativeMethodInfoPtr_Multiply_Public_Static_Color32_Color32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100664695);
			TMPro_ExtensionMethods.NativeMethodInfoPtr_Tint_Public_Static_Color32_Color32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100664696);
			TMPro_ExtensionMethods.NativeMethodInfoPtr_Tint_Public_Static_Color32_Color32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100664697);
			TMPro_ExtensionMethods.NativeMethodInfoPtr_MinAlpha_Public_Static_Color_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100664698);
			TMPro_ExtensionMethods.NativeMethodInfoPtr_Compare_Public_Static_Boolean_Vector3_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100664699);
			TMPro_ExtensionMethods.NativeMethodInfoPtr_Compare_Public_Static_Boolean_Quaternion_Quaternion_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100664700);
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x00033838 File Offset: 0x00031A38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464405, XrefRangeEnd = 464409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<int> ToIntArray(this string text)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_ExtensionMethods.NativeMethodInfoPtr_ToIntArray_Public_Static_Il2CppStructArray_1_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x0003387C File Offset: 0x00031A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464409, XrefRangeEnd = 464428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ArrayToString(this Il2CppStructArray<char> chars)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_ExtensionMethods.NativeMethodInfoPtr_ArrayToString_Public_Static_String_Il2CppStructArray_1_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x000338B8 File Offset: 0x00031AB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464428, XrefRangeEnd = 464435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string IntToString(this Il2CppStructArray<int> unicodes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unicodes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_ExtensionMethods.NativeMethodInfoPtr_IntToString_Public_Static_String_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000C2A RID: 3114 RVA: 0x000338F4 File Offset: 0x00031AF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 464444, RefRangeEnd = 464445, XrefRangeStart = 464435, XrefRangeEnd = 464444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string UintToString(this List<uint> unicodes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unicodes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_ExtensionMethods.NativeMethodInfoPtr_UintToString_Internal_Static_String_List_1_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x00033930 File Offset: 0x00031B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464445, XrefRangeEnd = 464454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string IntToString(this Il2CppStructArray<int> unicodes, int start, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unicodes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_ExtensionMethods.NativeMethodInfoPtr_IntToString_Public_Static_String_Il2CppStructArray_1_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x00033988 File Offset: 0x00031B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464454, XrefRangeEnd = 464457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindInstanceID<T>(this List<T> list, T target) where T : global::UnityEngine.Object
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = target;
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
				ptr4 = ref target;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_ExtensionMethods.MethodInfoStoreGeneric_FindInstanceID_Public_Static_Int32_List_1_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x00033A28 File Offset: 0x00031C28
		[CallerCount(0)]
		public unsafe static bool Compare(this Color32 a, Color32 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_ExtensionMethods.NativeMethodInfoPtr_Compare_Public_Static_Boolean_Color32_Color32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C2E RID: 3118 RVA: 0x00033A74 File Offset: 0x00031C74
		[CallerCount(0)]
		public unsafe static bool CompareRGB(this Color32 a, Color32 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_ExtensionMethods.NativeMethodInfoPtr_CompareRGB_Public_Static_Boolean_Color32_Color32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x00033AC0 File Offset: 0x00031CC0
		[CallerCount(0)]
		public unsafe static bool Compare(this Color a, Color b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_ExtensionMethods.NativeMethodInfoPtr_Compare_Public_Static_Boolean_Color_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x00033B0C File Offset: 0x00031D0C
		[CallerCount(0)]
		public unsafe static bool CompareRGB(this Color a, Color b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_ExtensionMethods.NativeMethodInfoPtr_CompareRGB_Public_Static_Boolean_Color_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C31 RID: 3121 RVA: 0x00033B58 File Offset: 0x00031D58
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 464457, RefRangeEnd = 464469, XrefRangeStart = 464457, XrefRangeEnd = 464457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color32 Multiply(this Color32 c1, Color32 c2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_ExtensionMethods.NativeMethodInfoPtr_Multiply_Public_Static_Color32_Color32_Color32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x00033BA4 File Offset: 0x00031DA4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 464457, RefRangeEnd = 464469, XrefRangeStart = 464457, XrefRangeEnd = 464469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color32 Tint(this Color32 c1, Color32 c2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_ExtensionMethods.NativeMethodInfoPtr_Tint_Public_Static_Color32_Color32_Color32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x00033BF0 File Offset: 0x00031DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464469, XrefRangeEnd = 464473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color32 Tint(this Color32 c1, float tint)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_ExtensionMethods.NativeMethodInfoPtr_Tint_Public_Static_Color32_Color32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x00033C3C File Offset: 0x00031E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464473, XrefRangeEnd = 464474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color MinAlpha(this Color c1, Color c2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_ExtensionMethods.NativeMethodInfoPtr_MinAlpha_Public_Static_Color_Color_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x00033C88 File Offset: 0x00031E88
		[CallerCount(0)]
		public unsafe static bool Compare(this Vector3 v1, Vector3 v2, int accuracy)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref accuracy;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_ExtensionMethods.NativeMethodInfoPtr_Compare_Public_Static_Boolean_Vector3_Vector3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x00033CE4 File Offset: 0x00031EE4
		[CallerCount(0)]
		public unsafe static bool Compare(this Quaternion q1, Quaternion q2, int accuracy)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref q1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref q2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref accuracy;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_ExtensionMethods.NativeMethodInfoPtr_Compare_Public_Static_Boolean_Quaternion_Quaternion_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x00007A4B File Offset: 0x00005C4B
		public TMPro_ExtensionMethods(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040009B1 RID: 2481
		private static readonly IntPtr NativeMethodInfoPtr_ToIntArray_Public_Static_Il2CppStructArray_1_Int32_String_0;

		// Token: 0x040009B2 RID: 2482
		private static readonly IntPtr NativeMethodInfoPtr_ArrayToString_Public_Static_String_Il2CppStructArray_1_Char_0;

		// Token: 0x040009B3 RID: 2483
		private static readonly IntPtr NativeMethodInfoPtr_IntToString_Public_Static_String_Il2CppStructArray_1_Int32_0;

		// Token: 0x040009B4 RID: 2484
		private static readonly IntPtr NativeMethodInfoPtr_UintToString_Internal_Static_String_List_1_UInt32_0;

		// Token: 0x040009B5 RID: 2485
		private static readonly IntPtr NativeMethodInfoPtr_IntToString_Public_Static_String_Il2CppStructArray_1_Int32_Int32_Int32_0;

		// Token: 0x040009B6 RID: 2486
		private static readonly IntPtr NativeMethodInfoPtr_FindInstanceID_Public_Static_Int32_List_1_T_T_0;

		// Token: 0x040009B7 RID: 2487
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Boolean_Color32_Color32_0;

		// Token: 0x040009B8 RID: 2488
		private static readonly IntPtr NativeMethodInfoPtr_CompareRGB_Public_Static_Boolean_Color32_Color32_0;

		// Token: 0x040009B9 RID: 2489
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Boolean_Color_Color_0;

		// Token: 0x040009BA RID: 2490
		private static readonly IntPtr NativeMethodInfoPtr_CompareRGB_Public_Static_Boolean_Color_Color_0;

		// Token: 0x040009BB RID: 2491
		private static readonly IntPtr NativeMethodInfoPtr_Multiply_Public_Static_Color32_Color32_Color32_0;

		// Token: 0x040009BC RID: 2492
		private static readonly IntPtr NativeMethodInfoPtr_Tint_Public_Static_Color32_Color32_Color32_0;

		// Token: 0x040009BD RID: 2493
		private static readonly IntPtr NativeMethodInfoPtr_Tint_Public_Static_Color32_Color32_Single_0;

		// Token: 0x040009BE RID: 2494
		private static readonly IntPtr NativeMethodInfoPtr_MinAlpha_Public_Static_Color_Color_Color_0;

		// Token: 0x040009BF RID: 2495
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Boolean_Vector3_Vector3_Int32_0;

		// Token: 0x040009C0 RID: 2496
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Boolean_Quaternion_Quaternion_Int32_0;

		// Token: 0x020000AF RID: 175
		private sealed class MethodInfoStoreGeneric_FindInstanceID_Public_Static_Int32_List_1_T_T_0<T>
		{
			// Token: 0x04000C8E RID: 3214
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TMPro_ExtensionMethods.NativeMethodInfoPtr_FindInstanceID_Public_Static_Int32_List_1_T_T_0, Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
