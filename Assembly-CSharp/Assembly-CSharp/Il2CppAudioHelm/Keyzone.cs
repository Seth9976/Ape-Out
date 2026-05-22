using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Audio;

namespace Il2CppAudioHelm
{
	// Token: 0x02000281 RID: 641
	[Serializable]
	public sealed class Keyzone : ValueType
	{
		// Token: 0x0600478F RID: 18319 RVA: 0x0010B6E0 File Offset: 0x001098E0
		// Note: this type is marked as 'beforefieldinit'.
		static Keyzone()
		{
			Il2CppClassPointerStore<Keyzone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AudioHelm", "Keyzone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Keyzone>.NativeClassPtr);
			Keyzone.NativeFieldInfoPtr_audioClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyzone>.NativeClassPtr, "audioClip");
			Keyzone.NativeFieldInfoPtr_mixer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyzone>.NativeClassPtr, "mixer");
			Keyzone.NativeFieldInfoPtr_rootKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyzone>.NativeClassPtr, "rootKey");
			Keyzone.NativeFieldInfoPtr_minKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyzone>.NativeClassPtr, "minKey");
			Keyzone.NativeFieldInfoPtr_maxKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyzone>.NativeClassPtr, "maxKey");
			Keyzone.NativeFieldInfoPtr_minVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyzone>.NativeClassPtr, "minVelocity");
			Keyzone.NativeFieldInfoPtr_maxVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyzone>.NativeClassPtr, "maxVelocity");
			Keyzone.NativeFieldInfoPtr_lastScheduled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyzone>.NativeClassPtr, "lastScheduled");
			Keyzone.NativeFieldInfoPtr_stereoPan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyzone>.NativeClassPtr, "stereoPan");
			Keyzone.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyzone>.NativeClassPtr, "index");
			Keyzone.NativeMethodInfoPtr_ValidForNote_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyzone>.NativeClassPtr, 100670660);
			Keyzone.NativeMethodInfoPtr_ValidForNote_Public_Boolean_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyzone>.NativeClassPtr, 100670661);
		}

		// Token: 0x06004790 RID: 18320 RVA: 0x0010B800 File Offset: 0x00109A00
		[CallerCount(0)]
		public unsafe bool ValidForNote(int note)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref note;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyzone.NativeMethodInfoPtr_ValidForNote_Public_Boolean_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004791 RID: 18321 RVA: 0x0010B850 File Offset: 0x00109A50
		[CallerCount(0)]
		public unsafe bool ValidForNote(int note, float velocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref note;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyzone.NativeMethodInfoPtr_ValidForNote_Public_Boolean_Int32_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004792 RID: 18322 RVA: 0x0002A2C5 File Offset: 0x000284C5
		public Keyzone(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06004793 RID: 18323 RVA: 0x0002A2CE File Offset: 0x000284CE
		public Keyzone()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Keyzone>.NativeClassPtr))
		{
		}

		// Token: 0x17001A19 RID: 6681
		// (get) Token: 0x06004794 RID: 18324 RVA: 0x0010B8AC File Offset: 0x00109AAC
		// (set) Token: 0x06004795 RID: 18325 RVA: 0x0002A2E0 File Offset: 0x000284E0
		public unsafe AudioClip audioClip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyzone.NativeFieldInfoPtr_audioClip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyzone.NativeFieldInfoPtr_audioClip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A1A RID: 6682
		// (get) Token: 0x06004796 RID: 18326 RVA: 0x0010B8DC File Offset: 0x00109ADC
		// (set) Token: 0x06004797 RID: 18327 RVA: 0x0002A2FF File Offset: 0x000284FF
		public unsafe AudioMixerGroup mixer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyzone.NativeFieldInfoPtr_mixer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixerGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyzone.NativeFieldInfoPtr_mixer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A1B RID: 6683
		// (get) Token: 0x06004798 RID: 18328 RVA: 0x0010B90C File Offset: 0x00109B0C
		// (set) Token: 0x06004799 RID: 18329 RVA: 0x0002A31E File Offset: 0x0002851E
		public unsafe int rootKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyzone.NativeFieldInfoPtr_rootKey);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyzone.NativeFieldInfoPtr_rootKey)) = value;
			}
		}

		// Token: 0x17001A1C RID: 6684
		// (get) Token: 0x0600479A RID: 18330 RVA: 0x0010B934 File Offset: 0x00109B34
		// (set) Token: 0x0600479B RID: 18331 RVA: 0x0002A339 File Offset: 0x00028539
		public unsafe int minKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyzone.NativeFieldInfoPtr_minKey);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyzone.NativeFieldInfoPtr_minKey)) = value;
			}
		}

		// Token: 0x17001A1D RID: 6685
		// (get) Token: 0x0600479C RID: 18332 RVA: 0x0010B95C File Offset: 0x00109B5C
		// (set) Token: 0x0600479D RID: 18333 RVA: 0x0002A354 File Offset: 0x00028554
		public unsafe int maxKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyzone.NativeFieldInfoPtr_maxKey);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyzone.NativeFieldInfoPtr_maxKey)) = value;
			}
		}

		// Token: 0x17001A1E RID: 6686
		// (get) Token: 0x0600479E RID: 18334 RVA: 0x0010B984 File Offset: 0x00109B84
		// (set) Token: 0x0600479F RID: 18335 RVA: 0x0002A36F File Offset: 0x0002856F
		public unsafe float minVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyzone.NativeFieldInfoPtr_minVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyzone.NativeFieldInfoPtr_minVelocity)) = value;
			}
		}

		// Token: 0x17001A1F RID: 6687
		// (get) Token: 0x060047A0 RID: 18336 RVA: 0x0010B9AC File Offset: 0x00109BAC
		// (set) Token: 0x060047A1 RID: 18337 RVA: 0x0002A38A File Offset: 0x0002858A
		public unsafe float maxVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyzone.NativeFieldInfoPtr_maxVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyzone.NativeFieldInfoPtr_maxVelocity)) = value;
			}
		}

		// Token: 0x17001A20 RID: 6688
		// (get) Token: 0x060047A2 RID: 18338 RVA: 0x0010B9D4 File Offset: 0x00109BD4
		// (set) Token: 0x060047A3 RID: 18339 RVA: 0x0002A3A5 File Offset: 0x000285A5
		public unsafe double lastScheduled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyzone.NativeFieldInfoPtr_lastScheduled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyzone.NativeFieldInfoPtr_lastScheduled)) = value;
			}
		}

		// Token: 0x17001A21 RID: 6689
		// (get) Token: 0x060047A4 RID: 18340 RVA: 0x0010B9FC File Offset: 0x00109BFC
		// (set) Token: 0x060047A5 RID: 18341 RVA: 0x0002A3C0 File Offset: 0x000285C0
		public unsafe float stereoPan
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyzone.NativeFieldInfoPtr_stereoPan);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyzone.NativeFieldInfoPtr_stereoPan)) = value;
			}
		}

		// Token: 0x17001A22 RID: 6690
		// (get) Token: 0x060047A6 RID: 18342 RVA: 0x0010BA24 File Offset: 0x00109C24
		// (set) Token: 0x060047A7 RID: 18343 RVA: 0x0002A3DB File Offset: 0x000285DB
		public unsafe int index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyzone.NativeFieldInfoPtr_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Keyzone.NativeFieldInfoPtr_index)) = value;
			}
		}

		// Token: 0x04002DC5 RID: 11717
		private static readonly IntPtr NativeFieldInfoPtr_audioClip;

		// Token: 0x04002DC6 RID: 11718
		private static readonly IntPtr NativeFieldInfoPtr_mixer;

		// Token: 0x04002DC7 RID: 11719
		private static readonly IntPtr NativeFieldInfoPtr_rootKey;

		// Token: 0x04002DC8 RID: 11720
		private static readonly IntPtr NativeFieldInfoPtr_minKey;

		// Token: 0x04002DC9 RID: 11721
		private static readonly IntPtr NativeFieldInfoPtr_maxKey;

		// Token: 0x04002DCA RID: 11722
		private static readonly IntPtr NativeFieldInfoPtr_minVelocity;

		// Token: 0x04002DCB RID: 11723
		private static readonly IntPtr NativeFieldInfoPtr_maxVelocity;

		// Token: 0x04002DCC RID: 11724
		private static readonly IntPtr NativeFieldInfoPtr_lastScheduled;

		// Token: 0x04002DCD RID: 11725
		private static readonly IntPtr NativeFieldInfoPtr_stereoPan;

		// Token: 0x04002DCE RID: 11726
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x04002DCF RID: 11727
		private static readonly IntPtr NativeMethodInfoPtr_ValidForNote_Public_Boolean_Int32_0;

		// Token: 0x04002DD0 RID: 11728
		private static readonly IntPtr NativeMethodInfoPtr_ValidForNote_Public_Boolean_Int32_Single_0;
	}
}
