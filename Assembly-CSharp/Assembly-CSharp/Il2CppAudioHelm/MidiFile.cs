using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using UnityEngine;

namespace Il2CppAudioHelm
{
	// Token: 0x02000282 RID: 642
	public class MidiFile : MonoBehaviour
	{
		// Token: 0x060047A8 RID: 18344 RVA: 0x0010BA4C File Offset: 0x00109C4C
		// Note: this type is marked as 'beforefieldinit'.
		static MidiFile()
		{
			Il2CppClassPointerStore<MidiFile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AudioHelm", "MidiFile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MidiFile>.NativeClassPtr);
			MidiFile.NativeFieldInfoPtr_midiObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiFile>.NativeClassPtr, "midiObject");
			MidiFile.NativeFieldInfoPtr_midiData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiFile>.NativeClassPtr, "midiData");
			MidiFile.NativeMethodInfoPtr_LoadMidiData_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiFile>.NativeClassPtr, 100670662);
			MidiFile.NativeMethodInfoPtr_LoadMidiData_Public_Static_MidiData_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiFile>.NativeClassPtr, 100670663);
			MidiFile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiFile>.NativeClassPtr, 100670664);
		}

		// Token: 0x060047A9 RID: 18345 RVA: 0x0010BAE0 File Offset: 0x00109CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116921, XrefRangeEnd = 116929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadMidiData(string filePath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiFile.NativeMethodInfoPtr_LoadMidiData_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060047AA RID: 18346 RVA: 0x0010BB24 File Offset: 0x00109D24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116929, XrefRangeEnd = 116933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MidiFile.MidiData LoadMidiData(Stream midiStream)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(midiStream);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiFile.NativeMethodInfoPtr_LoadMidiData_Public_Static_MidiData_Stream_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MidiFile.MidiData>(intPtr3) : null;
			}
		}

		// Token: 0x060047AB RID: 18347 RVA: 0x0010BB68 File Offset: 0x00109D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MidiFile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MidiFile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiFile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047AC RID: 18348 RVA: 0x0002A3F6 File Offset: 0x000285F6
		public MidiFile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001A23 RID: 6691
		// (get) Token: 0x060047AD RID: 18349 RVA: 0x0010BBA4 File Offset: 0x00109DA4
		// (set) Token: 0x060047AE RID: 18350 RVA: 0x0002A3FF File Offset: 0x000285FF
		public unsafe global::UnityEngine.Object midiObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiFile.NativeFieldInfoPtr_midiObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::UnityEngine.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiFile.NativeFieldInfoPtr_midiObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A24 RID: 6692
		// (get) Token: 0x060047AF RID: 18351 RVA: 0x0010BBD4 File Offset: 0x00109DD4
		// (set) Token: 0x060047B0 RID: 18352 RVA: 0x0002A41E File Offset: 0x0002861E
		public unsafe MidiFile.MidiData midiData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiFile.NativeFieldInfoPtr_midiData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MidiFile.MidiData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiFile.NativeFieldInfoPtr_midiData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002DD1 RID: 11729
		private static readonly IntPtr NativeFieldInfoPtr_midiObject;

		// Token: 0x04002DD2 RID: 11730
		private static readonly IntPtr NativeFieldInfoPtr_midiData;

		// Token: 0x04002DD3 RID: 11731
		private static readonly IntPtr NativeMethodInfoPtr_LoadMidiData_Public_Void_String_0;

		// Token: 0x04002DD4 RID: 11732
		private static readonly IntPtr NativeMethodInfoPtr_LoadMidiData_Public_Static_MidiData_Stream_0;

		// Token: 0x04002DD5 RID: 11733
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003E9 RID: 1001
		[Serializable]
		public class MidiData : global::Il2CppSystem.Object
		{
			// Token: 0x06005B2A RID: 23338 RVA: 0x00148FC4 File Offset: 0x001471C4
			// Note: this type is marked as 'beforefieldinit'.
			static MidiData()
			{
				Il2CppClassPointerStore<MidiFile.MidiData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MidiFile>.NativeClassPtr, "MidiData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MidiFile.MidiData>.NativeClassPtr);
				MidiFile.MidiData.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiFile.MidiData>.NativeClassPtr, "length");
				MidiFile.MidiData.NativeFieldInfoPtr_notes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiFile.MidiData>.NativeClassPtr, "notes");
				MidiFile.MidiData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiFile.MidiData>.NativeClassPtr, 100670665);
			}

			// Token: 0x06005B2B RID: 23339 RVA: 0x0014902C File Offset: 0x0014722C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 116918, RefRangeEnd = 116921, XrefRangeStart = 116908, XrefRangeEnd = 116918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MidiData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MidiFile.MidiData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiFile.MidiData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005B2C RID: 23340 RVA: 0x00034016 File Offset: 0x00032216
			public MidiData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002125 RID: 8485
			// (get) Token: 0x06005B2D RID: 23341 RVA: 0x00149068 File Offset: 0x00147268
			// (set) Token: 0x06005B2E RID: 23342 RVA: 0x0003401F File Offset: 0x0003221F
			public unsafe int length
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiFile.MidiData.NativeFieldInfoPtr_length);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiFile.MidiData.NativeFieldInfoPtr_length)) = value;
				}
			}

			// Token: 0x17002126 RID: 8486
			// (get) Token: 0x06005B2F RID: 23343 RVA: 0x00149090 File Offset: 0x00147290
			// (set) Token: 0x06005B30 RID: 23344 RVA: 0x0003403A File Offset: 0x0003223A
			public unsafe List<Note> notes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiFile.MidiData.NativeFieldInfoPtr_notes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Note>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiFile.MidiData.NativeFieldInfoPtr_notes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003C85 RID: 15493
			private static readonly IntPtr NativeFieldInfoPtr_length;

			// Token: 0x04003C86 RID: 15494
			private static readonly IntPtr NativeFieldInfoPtr_notes;

			// Token: 0x04003C87 RID: 15495
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
