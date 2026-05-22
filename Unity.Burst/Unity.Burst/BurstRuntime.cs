using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Unity.Burst
{
	// Token: 0x02000009 RID: 9
	public static class BurstRuntime : Object
	{
		// Token: 0x06000044 RID: 68 RVA: 0x00003380 File Offset: 0x00001580
		// Note: this type is marked as 'beforefieldinit'.
		static BurstRuntime()
		{
			Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Burst.dll", "Unity.Burst", "BurstRuntime");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr);
			BurstRuntime.NativeMethodInfoPtr_GetHashCode64_Public_Static_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr, 100663342);
			BurstRuntime.NativeMethodInfoPtr_HashStringWithFNV1A64_Internal_Static_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr, 100663343);
			BurstRuntime.NativeMethodInfoPtr_Log_Internal_Static_Void_ptr_Byte_Int32_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr, 100663344);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000033EC File Offset: 0x000015EC
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 146243, RefRangeEnd = 146316, XrefRangeStart = 146243, XrefRangeEnd = 146316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long GetHashCode64<T>()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstRuntime.MethodInfoStoreGeneric_GetHashCode64_Public_Static_Int64_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000341C File Offset: 0x0000161C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439695, XrefRangeEnd = 439696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long HashStringWithFNV1A64(string text)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstRuntime.NativeMethodInfoPtr_HashStringWithFNV1A64_Internal_Static_Int64_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00003460 File Offset: 0x00001660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439696, XrefRangeEnd = 439700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Log(byte* message, int logType, byte* fileName, int lineNumber)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = message;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref logType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = fileName;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNumber;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstRuntime.NativeMethodInfoPtr_Log_Internal_Static_Void_ptr_Byte_Int32_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000222B File Offset: 0x0000042B
		public BurstRuntime(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode64_Public_Static_Int64_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_HashStringWithFNV1A64_Internal_Static_Int64_String_0;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr_Log_Internal_Static_Void_ptr_Byte_Int32_ptr_Byte_Int32_0;

		// Token: 0x0200001B RID: 27
		public sealed class HashCode64<T> : ValueType
		{
			// Token: 0x0600008F RID: 143 RVA: 0x0000518C File Offset: 0x0000338C
			// Note: this type is marked as 'beforefieldinit'.
			static HashCode64()
			{
				Il2CppClassPointerStore<BurstRuntime.HashCode64<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr, "HashCode64`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstRuntime.HashCode64<T>>.NativeClassPtr);
				BurstRuntime.HashCode64<T>.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstRuntime.HashCode64<T>>.NativeClassPtr, "Value");
			}

			// Token: 0x06000090 RID: 144 RVA: 0x000024D3 File Offset: 0x000006D3
			public HashCode64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000091 RID: 145 RVA: 0x000024DC File Offset: 0x000006DC
			public HashCode64()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BurstRuntime.HashCode64<T>>.NativeClassPtr))
			{
			}

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x06000092 RID: 146 RVA: 0x00005208 File Offset: 0x00003408
			// (set) Token: 0x06000093 RID: 147 RVA: 0x000024EE File Offset: 0x000006EE
			public unsafe static long Value
			{
				get
				{
					long num;
					IL2CPP.il2cpp_field_static_get_value(BurstRuntime.HashCode64<T>.NativeFieldInfoPtr_Value, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BurstRuntime.HashCode64<T>.NativeFieldInfoPtr_Value, (void*)(&value));
				}
			}

			// Token: 0x0400022A RID: 554
			private static readonly IntPtr NativeFieldInfoPtr_Value;
		}

		// Token: 0x0200001C RID: 28
		public class PreserveAttribute : Attribute
		{
			// Token: 0x06000094 RID: 148 RVA: 0x000024FC File Offset: 0x000006FC
			// Note: this type is marked as 'beforefieldinit'.
			static PreserveAttribute()
			{
				Il2CppClassPointerStore<BurstRuntime.PreserveAttribute>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr, "PreserveAttribute");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstRuntime.PreserveAttribute>.NativeClassPtr);
				BurstRuntime.PreserveAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstRuntime.PreserveAttribute>.NativeClassPtr, 100663346);
			}

			// Token: 0x06000095 RID: 149 RVA: 0x00005224 File Offset: 0x00003424
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PreserveAttribute()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BurstRuntime.PreserveAttribute>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstRuntime.PreserveAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000096 RID: 150 RVA: 0x00002530 File Offset: 0x00000730
			public PreserveAttribute(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400022B RID: 555
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200001D RID: 29
		private sealed class MethodInfoStoreGeneric_GetHashCode64_Public_Static_Int64_0<T>
		{
			// Token: 0x0400022C RID: 556
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BurstRuntime.NativeMethodInfoPtr_GetHashCode64_Public_Static_Int64_0, Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
