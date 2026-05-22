using System;
using Il2CppAudioHelm;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200011F RID: 287
	public class LevelTitle : MonoBehaviour
	{
		// Token: 0x0600228E RID: 8846 RVA: 0x00094400 File Offset: 0x00092600
		// Note: this type is marked as 'beforefieldinit'.
		static LevelTitle()
		{
			Il2CppClassPointerStore<LevelTitle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "LevelTitle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LevelTitle>.NativeClassPtr);
			LevelTitle.NativeFieldInfoPtr_titles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelTitle>.NativeClassPtr, "titles");
			LevelTitle.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelTitle>.NativeClassPtr, "index");
			LevelTitle.NativeFieldInfoPtr_lastNotePlayedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelTitle>.NativeClassPtr, "lastNotePlayedTime");
			LevelTitle.NativeFieldInfoPtr_cleared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelTitle>.NativeClassPtr, "cleared");
			LevelTitle.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelTitle>.NativeClassPtr, "delay");
			LevelTitle.NativeFieldInfoPtr_delayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelTitle>.NativeClassPtr, "delayTime");
			LevelTitle.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelTitle>.NativeClassPtr, 100665971);
			LevelTitle.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelTitle>.NativeClassPtr, 100665972);
			LevelTitle.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelTitle>.NativeClassPtr, 100665973);
			LevelTitle.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelTitle>.NativeClassPtr, 100665974);
			LevelTitle.NativeMethodInfoPtr_NotePlayedDelayed_Private_IEnumerator_Note_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelTitle>.NativeClassPtr, 100665975);
			LevelTitle.NativeMethodInfoPtr_NotePlayed_Public_Void_Note_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelTitle>.NativeClassPtr, 100665976);
			LevelTitle.NativeMethodInfoPtr_Test_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelTitle>.NativeClassPtr, 100665977);
			LevelTitle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelTitle>.NativeClassPtr, 100665978);
		}

		// Token: 0x0600228F RID: 8847 RVA: 0x00094548 File Offset: 0x00092748
		[CallerCount(0)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelTitle.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002290 RID: 8848 RVA: 0x0009457C File Offset: 0x0009277C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 69408, RefRangeEnd = 69410, XrefRangeStart = 69405, XrefRangeEnd = 69408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelTitle.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002291 RID: 8849 RVA: 0x000945B0 File Offset: 0x000927B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69410, XrefRangeEnd = 69422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelTitle.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002292 RID: 8850 RVA: 0x000945E4 File Offset: 0x000927E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69422, XrefRangeEnd = 69425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelTitle.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002293 RID: 8851 RVA: 0x00094618 File Offset: 0x00092818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69425, XrefRangeEnd = 69428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator NotePlayedDelayed(Note note)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref note;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelTitle.NativeMethodInfoPtr_NotePlayedDelayed_Private_IEnumerator_Note_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06002294 RID: 8852 RVA: 0x00094664 File Offset: 0x00092864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69428, XrefRangeEnd = 69448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotePlayed(Note note)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref note;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelTitle.NativeMethodInfoPtr_NotePlayed_Public_Void_Note_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002295 RID: 8853 RVA: 0x000946A4 File Offset: 0x000928A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69448, XrefRangeEnd = 69451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Test()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelTitle.NativeMethodInfoPtr_Test_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002296 RID: 8854 RVA: 0x000946E4 File Offset: 0x000928E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69451, XrefRangeEnd = 69454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LevelTitle()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LevelTitle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelTitle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002297 RID: 8855 RVA: 0x0001843C File Offset: 0x0001663C
		public LevelTitle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C79 RID: 3193
		// (get) Token: 0x06002298 RID: 8856 RVA: 0x00094720 File Offset: 0x00092920
		// (set) Token: 0x06002299 RID: 8857 RVA: 0x00018445 File Offset: 0x00016645
		public unsafe Il2CppReferenceArray<GamArr> titles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTitle.NativeFieldInfoPtr_titles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GamArr>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTitle.NativeFieldInfoPtr_titles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C7A RID: 3194
		// (get) Token: 0x0600229A RID: 8858 RVA: 0x00094750 File Offset: 0x00092950
		// (set) Token: 0x0600229B RID: 8859 RVA: 0x00018464 File Offset: 0x00016664
		public unsafe int index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTitle.NativeFieldInfoPtr_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTitle.NativeFieldInfoPtr_index)) = value;
			}
		}

		// Token: 0x17000C7B RID: 3195
		// (get) Token: 0x0600229C RID: 8860 RVA: 0x00094778 File Offset: 0x00092978
		// (set) Token: 0x0600229D RID: 8861 RVA: 0x0001847F File Offset: 0x0001667F
		public unsafe float lastNotePlayedTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTitle.NativeFieldInfoPtr_lastNotePlayedTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTitle.NativeFieldInfoPtr_lastNotePlayedTime)) = value;
			}
		}

		// Token: 0x17000C7C RID: 3196
		// (get) Token: 0x0600229E RID: 8862 RVA: 0x000947A0 File Offset: 0x000929A0
		// (set) Token: 0x0600229F RID: 8863 RVA: 0x0001849A File Offset: 0x0001669A
		public unsafe bool cleared
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTitle.NativeFieldInfoPtr_cleared);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTitle.NativeFieldInfoPtr_cleared)) = value;
			}
		}

		// Token: 0x17000C7D RID: 3197
		// (get) Token: 0x060022A0 RID: 8864 RVA: 0x000947C8 File Offset: 0x000929C8
		// (set) Token: 0x060022A1 RID: 8865 RVA: 0x000184B5 File Offset: 0x000166B5
		public unsafe bool delay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTitle.NativeFieldInfoPtr_delay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTitle.NativeFieldInfoPtr_delay)) = value;
			}
		}

		// Token: 0x17000C7E RID: 3198
		// (get) Token: 0x060022A2 RID: 8866 RVA: 0x000947F0 File Offset: 0x000929F0
		// (set) Token: 0x060022A3 RID: 8867 RVA: 0x000184D0 File Offset: 0x000166D0
		public unsafe float delayTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTitle.NativeFieldInfoPtr_delayTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTitle.NativeFieldInfoPtr_delayTime)) = value;
			}
		}

		// Token: 0x04001462 RID: 5218
		private static readonly IntPtr NativeFieldInfoPtr_titles;

		// Token: 0x04001463 RID: 5219
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x04001464 RID: 5220
		private static readonly IntPtr NativeFieldInfoPtr_lastNotePlayedTime;

		// Token: 0x04001465 RID: 5221
		private static readonly IntPtr NativeFieldInfoPtr_cleared;

		// Token: 0x04001466 RID: 5222
		private static readonly IntPtr NativeFieldInfoPtr_delay;

		// Token: 0x04001467 RID: 5223
		private static readonly IntPtr NativeFieldInfoPtr_delayTime;

		// Token: 0x04001468 RID: 5224
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001469 RID: 5225
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x0400146A RID: 5226
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400146B RID: 5227
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

		// Token: 0x0400146C RID: 5228
		private static readonly IntPtr NativeMethodInfoPtr_NotePlayedDelayed_Private_IEnumerator_Note_0;

		// Token: 0x0400146D RID: 5229
		private static readonly IntPtr NativeMethodInfoPtr_NotePlayed_Public_Void_Note_0;

		// Token: 0x0400146E RID: 5230
		private static readonly IntPtr NativeMethodInfoPtr_Test_Public_IEnumerator_0;

		// Token: 0x0400146F RID: 5231
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000318 RID: 792
		[ObfuscatedName("LevelTitle+<NotePlayedDelayed>d__10")]
		public sealed class _NotePlayedDelayed_d__10 : global::Il2CppSystem.Object
		{
			// Token: 0x06005020 RID: 20512 RVA: 0x00124C68 File Offset: 0x00122E68
			// Note: this type is marked as 'beforefieldinit'.
			static _NotePlayedDelayed_d__10()
			{
				Il2CppClassPointerStore<LevelTitle._NotePlayedDelayed_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LevelTitle>.NativeClassPtr, "<NotePlayedDelayed>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LevelTitle._NotePlayedDelayed_d__10>.NativeClassPtr);
				LevelTitle._NotePlayedDelayed_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelTitle._NotePlayedDelayed_d__10>.NativeClassPtr, "<>1__state");
				LevelTitle._NotePlayedDelayed_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelTitle._NotePlayedDelayed_d__10>.NativeClassPtr, "<>2__current");
				LevelTitle._NotePlayedDelayed_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelTitle._NotePlayedDelayed_d__10>.NativeClassPtr, "<>4__this");
				LevelTitle._NotePlayedDelayed_d__10.NativeFieldInfoPtr_note = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelTitle._NotePlayedDelayed_d__10>.NativeClassPtr, "note");
				LevelTitle._NotePlayedDelayed_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelTitle._NotePlayedDelayed_d__10>.NativeClassPtr, 100665979);
				LevelTitle._NotePlayedDelayed_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelTitle._NotePlayedDelayed_d__10>.NativeClassPtr, 100665980);
				LevelTitle._NotePlayedDelayed_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelTitle._NotePlayedDelayed_d__10>.NativeClassPtr, 100665981);
				LevelTitle._NotePlayedDelayed_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelTitle._NotePlayedDelayed_d__10>.NativeClassPtr, 100665982);
				LevelTitle._NotePlayedDelayed_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelTitle._NotePlayedDelayed_d__10>.NativeClassPtr, 100665983);
				LevelTitle._NotePlayedDelayed_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelTitle._NotePlayedDelayed_d__10>.NativeClassPtr, 100665984);
			}

			// Token: 0x06005021 RID: 20513 RVA: 0x00124D5C File Offset: 0x00122F5C
			[CallerCount(0)]
			public unsafe _NotePlayedDelayed_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LevelTitle._NotePlayedDelayed_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelTitle._NotePlayedDelayed_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005022 RID: 20514 RVA: 0x00124DA4 File Offset: 0x00122FA4
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelTitle._NotePlayedDelayed_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005023 RID: 20515 RVA: 0x00124DD8 File Offset: 0x00122FD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69377, XrefRangeEnd = 69386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelTitle._NotePlayedDelayed_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001D38 RID: 7480
			// (get) Token: 0x06005024 RID: 20516 RVA: 0x00124E14 File Offset: 0x00123014
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelTitle._NotePlayedDelayed_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005025 RID: 20517 RVA: 0x00124E54 File Offset: 0x00123054
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69386, XrefRangeEnd = 69391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelTitle._NotePlayedDelayed_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001D39 RID: 7481
			// (get) Token: 0x06005026 RID: 20518 RVA: 0x00124E88 File Offset: 0x00123088
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelTitle._NotePlayedDelayed_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005027 RID: 20519 RVA: 0x0002EC9D File Offset: 0x0002CE9D
			public _NotePlayedDelayed_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001D34 RID: 7476
			// (get) Token: 0x06005028 RID: 20520 RVA: 0x00124EC8 File Offset: 0x001230C8
			// (set) Token: 0x06005029 RID: 20521 RVA: 0x0002ECA6 File Offset: 0x0002CEA6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTitle._NotePlayedDelayed_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTitle._NotePlayedDelayed_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001D35 RID: 7477
			// (get) Token: 0x0600502A RID: 20522 RVA: 0x00124EF0 File Offset: 0x001230F0
			// (set) Token: 0x0600502B RID: 20523 RVA: 0x0002ECC1 File Offset: 0x0002CEC1
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTitle._NotePlayedDelayed_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTitle._NotePlayedDelayed_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D36 RID: 7478
			// (get) Token: 0x0600502C RID: 20524 RVA: 0x00124F20 File Offset: 0x00123120
			// (set) Token: 0x0600502D RID: 20525 RVA: 0x0002ECE0 File Offset: 0x0002CEE0
			public unsafe LevelTitle __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTitle._NotePlayedDelayed_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LevelTitle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTitle._NotePlayedDelayed_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D37 RID: 7479
			// (get) Token: 0x0600502E RID: 20526 RVA: 0x00124F50 File Offset: 0x00123150
			// (set) Token: 0x0600502F RID: 20527 RVA: 0x0002ECFF File Offset: 0x0002CEFF
			public unsafe Note note
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTitle._NotePlayedDelayed_d__10.NativeFieldInfoPtr_note);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTitle._NotePlayedDelayed_d__10.NativeFieldInfoPtr_note)) = value;
				}
			}

			// Token: 0x04003501 RID: 13569
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003502 RID: 13570
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003503 RID: 13571
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003504 RID: 13572
			private static readonly IntPtr NativeFieldInfoPtr_note;

			// Token: 0x04003505 RID: 13573
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003506 RID: 13574
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003507 RID: 13575
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003508 RID: 13576
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003509 RID: 13577
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400350A RID: 13578
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000319 RID: 793
		[ObfuscatedName("LevelTitle+<Test>d__12")]
		public sealed class _Test_d__12 : global::Il2CppSystem.Object
		{
			// Token: 0x06005030 RID: 20528 RVA: 0x00124F78 File Offset: 0x00123178
			// Note: this type is marked as 'beforefieldinit'.
			static _Test_d__12()
			{
				Il2CppClassPointerStore<LevelTitle._Test_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LevelTitle>.NativeClassPtr, "<Test>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LevelTitle._Test_d__12>.NativeClassPtr);
				LevelTitle._Test_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelTitle._Test_d__12>.NativeClassPtr, "<>1__state");
				LevelTitle._Test_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelTitle._Test_d__12>.NativeClassPtr, "<>2__current");
				LevelTitle._Test_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelTitle._Test_d__12>.NativeClassPtr, "<>4__this");
				LevelTitle._Test_d__12.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelTitle._Test_d__12>.NativeClassPtr, "<i>5__2");
				LevelTitle._Test_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelTitle._Test_d__12>.NativeClassPtr, 100665985);
				LevelTitle._Test_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelTitle._Test_d__12>.NativeClassPtr, 100665986);
				LevelTitle._Test_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelTitle._Test_d__12>.NativeClassPtr, 100665987);
				LevelTitle._Test_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelTitle._Test_d__12>.NativeClassPtr, 100665988);
				LevelTitle._Test_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelTitle._Test_d__12>.NativeClassPtr, 100665989);
				LevelTitle._Test_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelTitle._Test_d__12>.NativeClassPtr, 100665990);
			}

			// Token: 0x06005031 RID: 20529 RVA: 0x0012506C File Offset: 0x0012326C
			[CallerCount(0)]
			public unsafe _Test_d__12(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LevelTitle._Test_d__12>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelTitle._Test_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005032 RID: 20530 RVA: 0x001250B4 File Offset: 0x001232B4
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelTitle._Test_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005033 RID: 20531 RVA: 0x001250E8 File Offset: 0x001232E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69391, XrefRangeEnd = 69396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelTitle._Test_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001D3E RID: 7486
			// (get) Token: 0x06005034 RID: 20532 RVA: 0x00125124 File Offset: 0x00123324
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelTitle._Test_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005035 RID: 20533 RVA: 0x00125164 File Offset: 0x00123364
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69396, XrefRangeEnd = 69405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelTitle._Test_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001D3F RID: 7487
			// (get) Token: 0x06005036 RID: 20534 RVA: 0x00125198 File Offset: 0x00123398
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelTitle._Test_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005037 RID: 20535 RVA: 0x0002ED1A File Offset: 0x0002CF1A
			public _Test_d__12(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001D3A RID: 7482
			// (get) Token: 0x06005038 RID: 20536 RVA: 0x001251D8 File Offset: 0x001233D8
			// (set) Token: 0x06005039 RID: 20537 RVA: 0x0002ED23 File Offset: 0x0002CF23
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTitle._Test_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTitle._Test_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001D3B RID: 7483
			// (get) Token: 0x0600503A RID: 20538 RVA: 0x00125200 File Offset: 0x00123400
			// (set) Token: 0x0600503B RID: 20539 RVA: 0x0002ED3E File Offset: 0x0002CF3E
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTitle._Test_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTitle._Test_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D3C RID: 7484
			// (get) Token: 0x0600503C RID: 20540 RVA: 0x00125230 File Offset: 0x00123430
			// (set) Token: 0x0600503D RID: 20541 RVA: 0x0002ED5D File Offset: 0x0002CF5D
			public unsafe LevelTitle __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTitle._Test_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LevelTitle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTitle._Test_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D3D RID: 7485
			// (get) Token: 0x0600503E RID: 20542 RVA: 0x00125260 File Offset: 0x00123460
			// (set) Token: 0x0600503F RID: 20543 RVA: 0x0002ED7C File Offset: 0x0002CF7C
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTitle._Test_d__12.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTitle._Test_d__12.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x0400350B RID: 13579
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400350C RID: 13580
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400350D RID: 13581
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400350E RID: 13582
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x0400350F RID: 13583
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003510 RID: 13584
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003511 RID: 13585
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003512 RID: 13586
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003513 RID: 13587
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003514 RID: 13588
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
