using System;
using System.Reflection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Dynamic.Utils
{
	// Token: 0x0200001B RID: 27
	[DefaultMember("Item")]
	public sealed class CacheDict<TKey, TValue> : Object
	{
		// Token: 0x0600010D RID: 269 RVA: 0x00007AAC File Offset: 0x00005CAC
		// Note: this type is marked as 'beforefieldinit'.
		static CacheDict()
		{
			Il2CppClassPointerStore<CacheDict<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Dynamic.Utils", "CacheDict`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CacheDict<TKey, TValue>>.NativeClassPtr);
			CacheDict<TKey, TValue>.NativeFieldInfoPtr__mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CacheDict<TKey, TValue>>.NativeClassPtr, "_mask");
			CacheDict<TKey, TValue>.NativeFieldInfoPtr__entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CacheDict<TKey, TValue>>.NativeClassPtr, "_entries");
			CacheDict<TKey, TValue>.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheDict<TKey, TValue>>.NativeClassPtr, 100663560);
			CacheDict<TKey, TValue>.NativeMethodInfoPtr_AlignSize_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheDict<TKey, TValue>>.NativeClassPtr, 100663561);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00007B7C File Offset: 0x00005D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363671, XrefRangeEnd = 363673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CacheDict(int size)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CacheDict<TKey, TValue>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheDict<TKey, TValue>.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00007BC4 File Offset: 0x00005DC4
		[CallerCount(0)]
		public unsafe static int AlignSize(int size)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheDict<TKey, TValue>.NativeMethodInfoPtr_AlignSize_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002649 File Offset: 0x00000849
		public CacheDict(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000111 RID: 273 RVA: 0x00007C04 File Offset: 0x00005E04
		// (set) Token: 0x06000112 RID: 274 RVA: 0x00002652 File Offset: 0x00000852
		public unsafe int _mask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheDict<TKey, TValue>.NativeFieldInfoPtr__mask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheDict<TKey, TValue>.NativeFieldInfoPtr__mask)) = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000113 RID: 275 RVA: 0x00007C2C File Offset: 0x00005E2C
		// (set) Token: 0x06000114 RID: 276 RVA: 0x0000266D File Offset: 0x0000086D
		public unsafe Il2CppReferenceArray<CacheDict<TKey, TValue>.Entry> _entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheDict<TKey, TValue>.NativeFieldInfoPtr__entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CacheDict<TKey, TValue>.Entry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheDict<TKey, TValue>.NativeFieldInfoPtr__entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeFieldInfoPtr__mask;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeFieldInfoPtr__entries;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeMethodInfoPtr_AlignSize_Private_Static_Int32_Int32_0;

		// Token: 0x0200005C RID: 92
		public sealed class Entry : Object
		{
			// Token: 0x060002ED RID: 749 RVA: 0x0000ECA0 File Offset: 0x0000CEA0
			// Note: this type is marked as 'beforefieldinit'.
			static Entry()
			{
				Il2CppClassPointerStore<CacheDict<TKey, TValue>.Entry>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CacheDict<TKey, TValue>>.NativeClassPtr, "Entry"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CacheDict<TKey, TValue>.Entry>.NativeClassPtr);
			}

			// Token: 0x060002EE RID: 750 RVA: 0x000033BA File Offset: 0x000015BA
			public Entry(IntPtr pointer)
				: base(pointer)
			{
			}
		}
	}
}
