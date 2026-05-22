using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x02000027 RID: 39
	public sealed class UnmanagedArray<T> : ValueType where T : new()
	{
		// Token: 0x06000117 RID: 279 RVA: 0x0000A14C File Offset: 0x0000834C
		// Note: this type is marked as 'beforefieldinit'.
		static UnmanagedArray()
		{
			Il2CppClassPointerStore<UnmanagedArray<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.Collections.dll", "Unity.Collections", "UnmanagedArray`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnmanagedArray<T>>.NativeClassPtr);
			UnmanagedArray<T>.NativeFieldInfoPtr_m_pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedArray<T>>.NativeClassPtr, "m_pointer");
			UnmanagedArray<T>.NativeFieldInfoPtr_m_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedArray<T>>.NativeClassPtr, "m_length");
			UnmanagedArray<T>.NativeFieldInfoPtr_m_allocator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedArray<T>>.NativeClassPtr, "m_allocator");
			UnmanagedArray<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedArray<T>>.NativeClassPtr, 100663514);
			UnmanagedArray<T>.NativeMethodInfoPtr_get_Item_Public_get_byref_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedArray<T>>.NativeClassPtr, 100663515);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0000A21C File Offset: 0x0000841C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440536, XrefRangeEnd = 440538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnmanagedArray<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700002E RID: 46
		public unsafe ref T this[int index]
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnmanagedArray<T>.NativeMethodInfoPtr_get_Item_Public_get_byref_T_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}
		}

		// Token: 0x0600011A RID: 282 RVA: 0x000025FF File Offset: 0x000007FF
		public UnmanagedArray(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002608 File Offset: 0x00000808
		public UnmanagedArray()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnmanagedArray<T>>.NativeClassPtr))
		{
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600011C RID: 284 RVA: 0x0000A298 File Offset: 0x00008498
		// (set) Token: 0x0600011D RID: 285 RVA: 0x0000261A File Offset: 0x0000081A
		public unsafe IntPtr m_pointer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedArray<T>.NativeFieldInfoPtr_m_pointer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedArray<T>.NativeFieldInfoPtr_m_pointer)) = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600011E RID: 286 RVA: 0x0000A2C0 File Offset: 0x000084C0
		// (set) Token: 0x0600011F RID: 287 RVA: 0x00002635 File Offset: 0x00000835
		public unsafe int m_length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedArray<T>.NativeFieldInfoPtr_m_length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedArray<T>.NativeFieldInfoPtr_m_length)) = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000120 RID: 288 RVA: 0x0000A2E8 File Offset: 0x000084E8
		// (set) Token: 0x06000121 RID: 289 RVA: 0x00002650 File Offset: 0x00000850
		public unsafe AllocatorManager.AllocatorHandle m_allocator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedArray<T>.NativeFieldInfoPtr_m_allocator);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedArray<T>.NativeFieldInfoPtr_m_allocator)) = value;
			}
		}

		// Token: 0x040003E2 RID: 994
		private static readonly IntPtr NativeFieldInfoPtr_m_pointer;

		// Token: 0x040003E3 RID: 995
		private static readonly IntPtr NativeFieldInfoPtr_m_length;

		// Token: 0x040003E4 RID: 996
		private static readonly IntPtr NativeFieldInfoPtr_m_allocator;

		// Token: 0x040003E5 RID: 997
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040003E6 RID: 998
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_byref_T_Int32_0;
	}
}
