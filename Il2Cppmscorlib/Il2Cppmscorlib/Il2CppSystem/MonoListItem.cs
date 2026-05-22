using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000124 RID: 292
	public sealed class MonoListItem : Object
	{
		// Token: 0x060014FB RID: 5371 RVA: 0x000841A0 File Offset: 0x000823A0
		// Note: this type is marked as 'beforefieldinit'.
		static MonoListItem()
		{
			Il2CppClassPointerStore<MonoListItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "MonoListItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoListItem>.NativeClassPtr);
			MonoListItem.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoListItem>.NativeClassPtr, "next");
			MonoListItem.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoListItem>.NativeClassPtr, "data");
			MonoListItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoListItem>.NativeClassPtr, 100666939);
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x0008420C File Offset: 0x0008240C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoListItem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoListItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoListItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x00007321 File Offset: 0x00005521
		public MonoListItem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x060014FE RID: 5374 RVA: 0x00084248 File Offset: 0x00082448
		// (set) Token: 0x060014FF RID: 5375 RVA: 0x0000732A File Offset: 0x0000552A
		public unsafe MonoListItem next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoListItem.NativeFieldInfoPtr_next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoListItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoListItem.NativeFieldInfoPtr_next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06001500 RID: 5376 RVA: 0x00084278 File Offset: 0x00082478
		// (set) Token: 0x06001501 RID: 5377 RVA: 0x00007349 File Offset: 0x00005549
		public unsafe Object data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoListItem.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoListItem.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040011F7 RID: 4599
		private static readonly IntPtr NativeFieldInfoPtr_next;

		// Token: 0x040011F8 RID: 4600
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x040011F9 RID: 4601
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
