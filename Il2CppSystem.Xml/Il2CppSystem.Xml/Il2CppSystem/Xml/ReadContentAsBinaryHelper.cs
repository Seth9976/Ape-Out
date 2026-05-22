using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200003B RID: 59
	public class ReadContentAsBinaryHelper : Object
	{
		// Token: 0x06000300 RID: 768 RVA: 0x0001F998 File Offset: 0x0001DB98
		// Note: this type is marked as 'beforefieldinit'.
		static ReadContentAsBinaryHelper()
		{
			Il2CppClassPointerStore<ReadContentAsBinaryHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "ReadContentAsBinaryHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadContentAsBinaryHelper>.NativeClassPtr);
			ReadContentAsBinaryHelper.NativeFieldInfoPtr_reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadContentAsBinaryHelper>.NativeClassPtr, "reader");
			ReadContentAsBinaryHelper.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadContentAsBinaryHelper>.NativeClassPtr, "state");
			ReadContentAsBinaryHelper.NativeFieldInfoPtr_valueOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadContentAsBinaryHelper>.NativeClassPtr, "valueOffset");
			ReadContentAsBinaryHelper.NativeFieldInfoPtr_isEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadContentAsBinaryHelper>.NativeClassPtr, "isEnd");
			ReadContentAsBinaryHelper.NativeMethodInfoPtr_Finish_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadContentAsBinaryHelper>.NativeClassPtr, 100663669);
			ReadContentAsBinaryHelper.NativeMethodInfoPtr_Reset_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadContentAsBinaryHelper>.NativeClassPtr, 100663670);
			ReadContentAsBinaryHelper.NativeMethodInfoPtr_MoveToNextContentNode_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadContentAsBinaryHelper>.NativeClassPtr, 100663671);
		}

		// Token: 0x06000301 RID: 769 RVA: 0x0001FA54 File Offset: 0x0001DC54
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 390186, RefRangeEnd = 390189, XrefRangeStart = 390184, XrefRangeEnd = 390186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Finish()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadContentAsBinaryHelper.NativeMethodInfoPtr_Finish_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000302 RID: 770 RVA: 0x0001FA88 File Offset: 0x0001DC88
		[CallerCount(0)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadContentAsBinaryHelper.NativeMethodInfoPtr_Reset_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000303 RID: 771 RVA: 0x0001FABC File Offset: 0x0001DCBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390189, XrefRangeEnd = 390190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveToNextContentNode(bool moveIfOnContentNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref moveIfOnContentNode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadContentAsBinaryHelper.NativeMethodInfoPtr_MoveToNextContentNode_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000304 RID: 772 RVA: 0x0000325E File Offset: 0x0000145E
		public ReadContentAsBinaryHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000305 RID: 773 RVA: 0x0001FB08 File Offset: 0x0001DD08
		// (set) Token: 0x06000306 RID: 774 RVA: 0x00003267 File Offset: 0x00001467
		public unsafe XmlReader reader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadContentAsBinaryHelper.NativeFieldInfoPtr_reader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadContentAsBinaryHelper.NativeFieldInfoPtr_reader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000307 RID: 775 RVA: 0x0001FB38 File Offset: 0x0001DD38
		// (set) Token: 0x06000308 RID: 776 RVA: 0x00003286 File Offset: 0x00001486
		public unsafe ReadContentAsBinaryHelper.State state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadContentAsBinaryHelper.NativeFieldInfoPtr_state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadContentAsBinaryHelper.NativeFieldInfoPtr_state)) = value;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000309 RID: 777 RVA: 0x0001FB60 File Offset: 0x0001DD60
		// (set) Token: 0x0600030A RID: 778 RVA: 0x000032A1 File Offset: 0x000014A1
		public unsafe int valueOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadContentAsBinaryHelper.NativeFieldInfoPtr_valueOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadContentAsBinaryHelper.NativeFieldInfoPtr_valueOffset)) = value;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x0600030B RID: 779 RVA: 0x0001FB88 File Offset: 0x0001DD88
		// (set) Token: 0x0600030C RID: 780 RVA: 0x000032BC File Offset: 0x000014BC
		public unsafe bool isEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadContentAsBinaryHelper.NativeFieldInfoPtr_isEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadContentAsBinaryHelper.NativeFieldInfoPtr_isEnd)) = value;
			}
		}

		// Token: 0x0400020F RID: 527
		private static readonly IntPtr NativeFieldInfoPtr_reader;

		// Token: 0x04000210 RID: 528
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x04000211 RID: 529
		private static readonly IntPtr NativeFieldInfoPtr_valueOffset;

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeFieldInfoPtr_isEnd;

		// Token: 0x04000213 RID: 531
		private static readonly IntPtr NativeMethodInfoPtr_Finish_Internal_Void_0;

		// Token: 0x04000214 RID: 532
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Void_0;

		// Token: 0x04000215 RID: 533
		private static readonly IntPtr NativeMethodInfoPtr_MoveToNextContentNode_Private_Boolean_Boolean_0;

		// Token: 0x020001F7 RID: 503
		[OriginalName("System.Xml.dll", "", "State")]
		public enum State
		{
			// Token: 0x04002014 RID: 8212
			None,
			// Token: 0x04002015 RID: 8213
			InReadContent,
			// Token: 0x04002016 RID: 8214
			InReadElementContent
		}
	}
}
