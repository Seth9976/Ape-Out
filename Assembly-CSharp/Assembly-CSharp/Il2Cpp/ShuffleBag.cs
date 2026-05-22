using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp
{
	// Token: 0x02000012 RID: 18
	[Serializable]
	public class ShuffleBag : Object
	{
		// Token: 0x060002B4 RID: 692 RVA: 0x0003B204 File Offset: 0x00039404
		// Note: this type is marked as 'beforefieldinit'.
		static ShuffleBag()
		{
			Il2CppClassPointerStore<ShuffleBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ShuffleBag");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShuffleBag>.NativeClassPtr);
			ShuffleBag.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShuffleBag>.NativeClassPtr, "data");
			ShuffleBag.NativeFieldInfoPtr_currentItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShuffleBag>.NativeClassPtr, "currentItem");
			ShuffleBag.NativeFieldInfoPtr_currentPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShuffleBag>.NativeClassPtr, "currentPosition");
			ShuffleBag.NativeFieldInfoPtr_lastAddedIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShuffleBag>.NativeClassPtr, "lastAddedIndex");
			ShuffleBag.NativeMethodInfoPtr_get_Size_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShuffleBag>.NativeClassPtr, 100663437);
			ShuffleBag.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShuffleBag>.NativeClassPtr, 100663438);
			ShuffleBag.NativeMethodInfoPtr_Add_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShuffleBag>.NativeClassPtr, 100663439);
			ShuffleBag.NativeMethodInfoPtr_Next_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShuffleBag>.NativeClassPtr, 100663440);
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x0003B2D4 File Offset: 0x000394D4
		public unsafe int Size
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShuffleBag.NativeMethodInfoPtr_get_Size_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0003B310 File Offset: 0x00039510
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 32814, RefRangeEnd = 32815, XrefRangeStart = 32811, XrefRangeEnd = 32814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShuffleBag(int initCapacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShuffleBag>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initCapacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShuffleBag.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0003B358 File Offset: 0x00039558
		[CallerCount(0)]
		public unsafe void Add(int item, int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref item;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShuffleBag.NativeMethodInfoPtr_Add_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0003B3A4 File Offset: 0x000395A4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 32817, RefRangeEnd = 32827, XrefRangeStart = 32815, XrefRangeEnd = 32817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Next()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShuffleBag.NativeMethodInfoPtr_Next_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x000040C2 File Offset: 0x000022C2
		public ShuffleBag(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060002BA RID: 698 RVA: 0x0003B3E0 File Offset: 0x000395E0
		// (set) Token: 0x060002BB RID: 699 RVA: 0x000040CB File Offset: 0x000022CB
		public unsafe Il2CppStructArray<int> data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShuffleBag.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShuffleBag.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060002BC RID: 700 RVA: 0x0003B410 File Offset: 0x00039610
		// (set) Token: 0x060002BD RID: 701 RVA: 0x000040EA File Offset: 0x000022EA
		public unsafe int currentItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShuffleBag.NativeFieldInfoPtr_currentItem);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShuffleBag.NativeFieldInfoPtr_currentItem)) = value;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060002BE RID: 702 RVA: 0x0003B438 File Offset: 0x00039638
		// (set) Token: 0x060002BF RID: 703 RVA: 0x00004105 File Offset: 0x00002305
		public unsafe int currentPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShuffleBag.NativeFieldInfoPtr_currentPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShuffleBag.NativeFieldInfoPtr_currentPosition)) = value;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x0003B460 File Offset: 0x00039660
		// (set) Token: 0x060002C1 RID: 705 RVA: 0x00004120 File Offset: 0x00002320
		public unsafe int lastAddedIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShuffleBag.NativeFieldInfoPtr_lastAddedIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShuffleBag.NativeFieldInfoPtr_lastAddedIndex)) = value;
			}
		}

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeFieldInfoPtr_currentItem;

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeFieldInfoPtr_currentPosition;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeFieldInfoPtr_lastAddedIndex;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeMethodInfoPtr_get_Size_Public_get_Int32_0;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_Int32_Int32_0;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeMethodInfoPtr_Next_Public_Int32_0;
	}
}
