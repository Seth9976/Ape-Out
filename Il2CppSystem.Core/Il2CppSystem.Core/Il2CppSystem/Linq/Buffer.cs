using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Linq
{
	// Token: 0x02000013 RID: 19
	public sealed class Buffer<TElement> : ValueType
	{
		// Token: 0x060000E9 RID: 233 RVA: 0x000074E0 File Offset: 0x000056E0
		// Note: this type is marked as 'beforefieldinit'.
		static Buffer()
		{
			Il2CppClassPointerStore<Buffer<TElement>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq", "Buffer`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Buffer<TElement>>.NativeClassPtr);
			Buffer<TElement>.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buffer<TElement>>.NativeClassPtr, "items");
			Buffer<TElement>.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buffer<TElement>>.NativeClassPtr, "count");
			Buffer<TElement>.NativeMethodInfoPtr__ctor_Internal_Void_IEnumerable_1_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer<TElement>>.NativeClassPtr, 100663550);
			Buffer<TElement>.NativeMethodInfoPtr_ToArray_Internal_Il2CppArrayBase_1_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer<TElement>>.NativeClassPtr, 100663551);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000759C File Offset: 0x0000579C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 363627, RefRangeEnd = 363629, XrefRangeStart = 363591, XrefRangeEnd = 363627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Buffer(IEnumerable<TElement> source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Buffer<TElement>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Buffer<TElement>.NativeMethodInfoPtr__ctor_Internal_Void_IEnumerable_1_TElement_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x000075EC File Offset: 0x000057EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363629, XrefRangeEnd = 363633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<TElement> ToArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Buffer<TElement>.NativeMethodInfoPtr_ToArray_Internal_Il2CppArrayBase_1_TElement_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<TElement>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000024EA File Offset: 0x000006EA
		public Buffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000024F3 File Offset: 0x000006F3
		public Buffer()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Buffer<TElement>>.NativeClassPtr))
		{
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000EE RID: 238 RVA: 0x00007628 File Offset: 0x00005828
		// (set) Token: 0x060000EF RID: 239 RVA: 0x00002505 File Offset: 0x00000705
		public unsafe Il2CppArrayBase<TElement> items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Buffer<TElement>.NativeFieldInfoPtr_items);
				return Il2CppArrayBase<TElement>.WrapNativeGenericArrayPointer(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Buffer<TElement>.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00007650 File Offset: 0x00005850
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x00002524 File Offset: 0x00000724
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Buffer<TElement>.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Buffer<TElement>.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeFieldInfoPtr_items;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IEnumerable_1_TElement_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr_ToArray_Internal_Il2CppArrayBase_1_TElement_0;
	}
}
