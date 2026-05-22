using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace Il2CppSanford.Collections.Immutable
{
	// Token: 0x020001D9 RID: 473
	public class AvlEnumerator : Object
	{
		// Token: 0x060017CD RID: 6093 RVA: 0x0006B178 File Offset: 0x00069378
		// Note: this type is marked as 'beforefieldinit'.
		static AvlEnumerator()
		{
			Il2CppClassPointerStore<AvlEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Collections.Immutable", "AvlEnumerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvlEnumerator>.NativeClassPtr);
			AvlEnumerator.NativeFieldInfoPtr_root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvlEnumerator>.NativeClassPtr, "root");
			AvlEnumerator.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvlEnumerator>.NativeClassPtr, "count");
			AvlEnumerator.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvlEnumerator>.NativeClassPtr, "current");
			AvlEnumerator.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvlEnumerator>.NativeClassPtr, "index");
			AvlEnumerator.NativeFieldInfoPtr_nodeStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvlEnumerator>.NativeClassPtr, "nodeStack");
			AvlEnumerator.NativeMethodInfoPtr__ctor_Public_Void_IAvlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvlEnumerator>.NativeClassPtr, 100666751);
			AvlEnumerator.NativeMethodInfoPtr__ctor_Public_Void_IAvlNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvlEnumerator>.NativeClassPtr, 100666752);
			AvlEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvlEnumerator>.NativeClassPtr, 100666753);
			AvlEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvlEnumerator>.NativeClassPtr, 100666754);
			AvlEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvlEnumerator>.NativeClassPtr, 100666755);
		}

		// Token: 0x060017CE RID: 6094 RVA: 0x0006B270 File Offset: 0x00069470
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 19208, RefRangeEnd = 19211, XrefRangeStart = 19199, XrefRangeEnd = 19208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvlEnumerator(IAvlNode root)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvlEnumerator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvlEnumerator.NativeMethodInfoPtr__ctor_Public_Void_IAvlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017CF RID: 6095 RVA: 0x0006B2BC File Offset: 0x000694BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19211, XrefRangeEnd = 19216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvlEnumerator(IAvlNode root, int count)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvlEnumerator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvlEnumerator.NativeMethodInfoPtr__ctor_Public_Void_IAvlNode_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017D0 RID: 6096 RVA: 0x0006B318 File Offset: 0x00069518
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 19225, RefRangeEnd = 19230, XrefRangeStart = 19216, XrefRangeEnd = 19225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvlEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x060017D1 RID: 6097 RVA: 0x0006B34C File Offset: 0x0006954C
		public unsafe virtual Object Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvlEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060017D2 RID: 6098 RVA: 0x0006B38C File Offset: 0x0006958C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 19232, RefRangeEnd = 19233, XrefRangeStart = 19230, XrefRangeEnd = 19232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvlEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017D3 RID: 6099 RVA: 0x0000984A File Offset: 0x00007A4A
		public AvlEnumerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x060017D4 RID: 6100 RVA: 0x0006B3C8 File Offset: 0x000695C8
		// (set) Token: 0x060017D5 RID: 6101 RVA: 0x00009853 File Offset: 0x00007A53
		public unsafe IAvlNode root
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvlEnumerator.NativeFieldInfoPtr_root);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAvlNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvlEnumerator.NativeFieldInfoPtr_root), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x060017D6 RID: 6102 RVA: 0x0006B3F8 File Offset: 0x000695F8
		// (set) Token: 0x060017D7 RID: 6103 RVA: 0x00009872 File Offset: 0x00007A72
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvlEnumerator.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvlEnumerator.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x060017D8 RID: 6104 RVA: 0x0006B420 File Offset: 0x00069620
		// (set) Token: 0x060017D9 RID: 6105 RVA: 0x0000988D File Offset: 0x00007A8D
		public unsafe Object current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvlEnumerator.NativeFieldInfoPtr_current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvlEnumerator.NativeFieldInfoPtr_current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x060017DA RID: 6106 RVA: 0x0006B450 File Offset: 0x00069650
		// (set) Token: 0x060017DB RID: 6107 RVA: 0x000098AC File Offset: 0x00007AAC
		public unsafe int index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvlEnumerator.NativeFieldInfoPtr_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvlEnumerator.NativeFieldInfoPtr_index)) = value;
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x060017DC RID: 6108 RVA: 0x0006B478 File Offset: 0x00069678
		// (set) Token: 0x060017DD RID: 6109 RVA: 0x000098C7 File Offset: 0x00007AC7
		public unsafe Stack nodeStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvlEnumerator.NativeFieldInfoPtr_nodeStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvlEnumerator.NativeFieldInfoPtr_nodeStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001920 RID: 6432
		private static readonly IntPtr NativeFieldInfoPtr_root;

		// Token: 0x04001921 RID: 6433
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x04001922 RID: 6434
		private static readonly IntPtr NativeFieldInfoPtr_current;

		// Token: 0x04001923 RID: 6435
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x04001924 RID: 6436
		private static readonly IntPtr NativeFieldInfoPtr_nodeStack;

		// Token: 0x04001925 RID: 6437
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IAvlNode_0;

		// Token: 0x04001926 RID: 6438
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IAvlNode_Int32_0;

		// Token: 0x04001927 RID: 6439
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001928 RID: 6440
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x04001929 RID: 6441
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;
	}
}
