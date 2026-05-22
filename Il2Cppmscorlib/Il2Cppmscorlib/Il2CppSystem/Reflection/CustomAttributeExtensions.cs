using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Reflection
{
	// Token: 0x0200018D RID: 397
	public static class CustomAttributeExtensions : Object
	{
		// Token: 0x06001BA8 RID: 7080 RVA: 0x000A1654 File Offset: 0x0009F854
		// Note: this type is marked as 'beforefieldinit'.
		static CustomAttributeExtensions()
		{
			Il2CppClassPointerStore<CustomAttributeExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "CustomAttributeExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomAttributeExtensions>.NativeClassPtr);
			CustomAttributeExtensions.NativeMethodInfoPtr_GetCustomAttribute_Public_Static_Attribute_Assembly_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeExtensions>.NativeClassPtr, 100668012);
			CustomAttributeExtensions.NativeMethodInfoPtr_GetCustomAttribute_Public_Static_Attribute_MemberInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeExtensions>.NativeClassPtr, 100668013);
			CustomAttributeExtensions.NativeMethodInfoPtr_GetCustomAttribute_Public_Static_T_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeExtensions>.NativeClassPtr, 100668014);
			CustomAttributeExtensions.NativeMethodInfoPtr_GetCustomAttribute_Public_Static_T_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeExtensions>.NativeClassPtr, 100668015);
			CustomAttributeExtensions.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IEnumerable_1_Attribute_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeExtensions>.NativeClassPtr, 100668016);
		}

		// Token: 0x06001BA9 RID: 7081 RVA: 0x000A16E8 File Offset: 0x0009F8E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Attribute GetCustomAttribute(this Assembly element, Type attributeType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeExtensions.NativeMethodInfoPtr_GetCustomAttribute_Public_Static_Attribute_Assembly_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Attribute>(intPtr3) : null;
		}

		// Token: 0x06001BAA RID: 7082 RVA: 0x000A1740 File Offset: 0x0009F940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Attribute GetCustomAttribute(this MemberInfo element, Type attributeType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeExtensions.NativeMethodInfoPtr_GetCustomAttribute_Public_Static_Attribute_MemberInfo_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Attribute>(intPtr3) : null;
		}

		// Token: 0x06001BAB RID: 7083 RVA: 0x000A1798 File Offset: 0x0009F998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186069, XrefRangeEnd = 186077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetCustomAttribute<T>(this Assembly element) where T : Attribute
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeExtensions.MethodInfoStoreGeneric_GetCustomAttribute_Public_Static_T_Assembly_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06001BAC RID: 7084 RVA: 0x000A17D8 File Offset: 0x0009F9D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 186083, RefRangeEnd = 186086, XrefRangeStart = 186077, XrefRangeEnd = 186083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetCustomAttribute<T>(this MemberInfo element) where T : Attribute
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeExtensions.MethodInfoStoreGeneric_GetCustomAttribute_Public_Static_T_MemberInfo_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06001BAD RID: 7085 RVA: 0x000A1818 File Offset: 0x0009FA18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Attribute> GetCustomAttributes(this MemberInfo element)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeExtensions.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IEnumerable_1_Attribute_MemberInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Attribute>>(intPtr3) : null;
			}
		}

		// Token: 0x06001BAE RID: 7086 RVA: 0x00009647 File Offset: 0x00007847
		public CustomAttributeExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001915 RID: 6421
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttribute_Public_Static_Attribute_Assembly_Type_0;

		// Token: 0x04001916 RID: 6422
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttribute_Public_Static_Attribute_MemberInfo_Type_0;

		// Token: 0x04001917 RID: 6423
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttribute_Public_Static_T_Assembly_0;

		// Token: 0x04001918 RID: 6424
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttribute_Public_Static_T_MemberInfo_0;

		// Token: 0x04001919 RID: 6425
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IEnumerable_1_Attribute_MemberInfo_0;

		// Token: 0x020005C4 RID: 1476
		private sealed class MethodInfoStoreGeneric_GetCustomAttribute_Public_Static_T_Assembly_0<T>
		{
			// Token: 0x0400430C RID: 17164
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CustomAttributeExtensions.NativeMethodInfoPtr_GetCustomAttribute_Public_Static_T_Assembly_0, Il2CppClassPointerStore<CustomAttributeExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005C5 RID: 1477
		private sealed class MethodInfoStoreGeneric_GetCustomAttribute_Public_Static_T_MemberInfo_0<T>
		{
			// Token: 0x0400430D RID: 17165
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CustomAttributeExtensions.NativeMethodInfoPtr_GetCustomAttribute_Public_Static_T_MemberInfo_0, Il2CppClassPointerStore<CustomAttributeExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
