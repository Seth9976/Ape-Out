using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppAudioHelm
{
	// Token: 0x02000286 RID: 646
	[Serializable]
	public sealed class NoteRow : ValueType
	{
		// Token: 0x060047E7 RID: 18407 RVA: 0x0010CF50 File Offset: 0x0010B150
		// Note: this type is marked as 'beforefieldinit'.
		static NoteRow()
		{
			Il2CppClassPointerStore<NoteRow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AudioHelm", "NoteRow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteRow>.NativeClassPtr);
			NoteRow.NativeFieldInfoPtr_notes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteRow>.NativeClassPtr, "notes");
			NoteRow.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Note_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteRow>.NativeClassPtr, 100670714);
		}

		// Token: 0x060047E8 RID: 18408 RVA: 0x0010CFA8 File Offset: 0x0010B1A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 99329, RefRangeEnd = 99331, XrefRangeStart = 99329, XrefRangeEnd = 99331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoteRow(Il2CppStructArray<Note> _notes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteRow>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_notes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteRow.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Note_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060047E9 RID: 18409 RVA: 0x0002A461 File Offset: 0x00028661
		public NoteRow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060047EA RID: 18410 RVA: 0x0002A46A File Offset: 0x0002866A
		public NoteRow()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteRow>.NativeClassPtr))
		{
		}

		// Token: 0x17001A25 RID: 6693
		// (get) Token: 0x060047EB RID: 18411 RVA: 0x0010CFF8 File Offset: 0x0010B1F8
		// (set) Token: 0x060047EC RID: 18412 RVA: 0x0002A47C File Offset: 0x0002867C
		public unsafe Il2CppStructArray<Note> notes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteRow.NativeFieldInfoPtr_notes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Note>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteRow.NativeFieldInfoPtr_notes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002E22 RID: 11810
		private static readonly IntPtr NativeFieldInfoPtr_notes;

		// Token: 0x04002E23 RID: 11811
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Note_0;
	}
}
