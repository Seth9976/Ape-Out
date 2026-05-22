using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Unity.Burst
{
	// Token: 0x0200000B RID: 11
	public sealed class SharedStatic<T> : ValueType where T : new()
	{
		// Token: 0x0600004F RID: 79 RVA: 0x000035B8 File Offset: 0x000017B8
		// Note: this type is marked as 'beforefieldinit'.
		static SharedStatic()
		{
			Il2CppClassPointerStore<SharedStatic<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.Burst.dll", "Unity.Burst", "SharedStatic`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SharedStatic<T>>.NativeClassPtr);
			SharedStatic<T>.NativeFieldInfoPtr__buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedStatic<T>>.NativeClassPtr, "_buffer");
			SharedStatic<T>.NativeMethodInfoPtr__ctor_Private_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedStatic<T>>.NativeClassPtr, 100663349);
			SharedStatic<T>.NativeMethodInfoPtr_get_Data_Public_get_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedStatic<T>>.NativeClassPtr, 100663350);
			SharedStatic<T>.NativeMethodInfoPtr_GetOrCreate_Public_Static_SharedStatic_1_T_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedStatic<T>>.NativeClassPtr, 100663351);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00003674 File Offset: 0x00001874
		[CallerCount(0)]
		public unsafe SharedStatic(void* buffer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SharedStatic<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = buffer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedStatic<T>.NativeMethodInfoPtr__ctor_Private_Void_ptr_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000051 RID: 81 RVA: 0x000036C0 File Offset: 0x000018C0
		public unsafe ref T Data
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439708, XrefRangeEnd = 439710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedStatic<T>.NativeMethodInfoPtr_get_Data_Public_get_byref_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000036F8 File Offset: 0x000018F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439710, XrefRangeEnd = 439718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SharedStatic<T> GetOrCreate<TContext>(uint alignment = 0U)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref alignment;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedStatic<TContext>.MethodInfoStoreGeneric_GetOrCreate_Public_Static_SharedStatic_1_T_UInt32_0.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new SharedStatic<T>(intPtr);
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0000226A File Offset: 0x0000046A
		public SharedStatic(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002273 File Offset: 0x00000473
		public SharedStatic()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SharedStatic<T>>.NativeClassPtr))
		{
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00003730 File Offset: 0x00001930
		// (set) Token: 0x06000056 RID: 86 RVA: 0x00002285 File Offset: 0x00000485
		public unsafe void* _buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedStatic<T>.NativeFieldInfoPtr__buffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedStatic<T>.NativeFieldInfoPtr__buffer)) = value;
			}
		}

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeFieldInfoPtr__buffer;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_ptr_Void_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_get_byref_T_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_GetOrCreate_Public_Static_SharedStatic_1_T_UInt32_0;

		// Token: 0x0200001E RID: 30
		private sealed class MethodInfoStoreGeneric_GetOrCreate_Public_Static_SharedStatic_1_T_UInt32_0
		{
			// Token: 0x0400022D RID: 557
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SharedStatic<TContext>.NativeMethodInfoPtr_GetOrCreate_Public_Static_SharedStatic_1_T_UInt32_0, Il2CppClassPointerStore<SharedStatic<TContext>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TContext>.NativeClassPtr)) }))));
		}
	}
}
