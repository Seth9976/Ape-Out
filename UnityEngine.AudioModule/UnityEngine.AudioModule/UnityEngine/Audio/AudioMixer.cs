using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Audio
{
	// Token: 0x0200000F RID: 15
	public class AudioMixer : Object
	{
		// Token: 0x0600010E RID: 270 RVA: 0x00006770 File Offset: 0x00004970
		// Note: this type is marked as 'beforefieldinit'.
		static AudioMixer()
		{
			Il2CppClassPointerStore<AudioMixer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AudioModule.dll", "UnityEngine.Audio", "AudioMixer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioMixer>.NativeClassPtr);
			AudioMixer.NativeMethodInfoPtr_SetFloat_Public_Boolean_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioMixer>.NativeClassPtr, 100663428);
			AudioMixer.NativeMethodInfoPtr_GetFloat_Public_Boolean_String_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioMixer>.NativeClassPtr, 100663429);
			AudioMixer.get_outputAudioMixerGroupDelegateField = IL2CPP.ResolveICall<AudioMixer.get_outputAudioMixerGroupDelegate>("UnityEngine.Audio.AudioMixer::get_outputAudioMixerGroup");
			AudioMixer.set_outputAudioMixerGroupDelegateField = IL2CPP.ResolveICall<AudioMixer.set_outputAudioMixerGroupDelegate>("UnityEngine.Audio.AudioMixer::set_outputAudioMixerGroup");
			AudioMixer.FindSnapshotDelegateField = IL2CPP.ResolveICall<AudioMixer.FindSnapshotDelegate>("UnityEngine.Audio.AudioMixer::FindSnapshot");
			AudioMixer.FindMatchingGroupsDelegateField = IL2CPP.ResolveICall<AudioMixer.FindMatchingGroupsDelegate>("UnityEngine.Audio.AudioMixer::FindMatchingGroups");
			AudioMixer.TransitionToSnapshotInternalDelegateField = IL2CPP.ResolveICall<AudioMixer.TransitionToSnapshotInternalDelegate>("UnityEngine.Audio.AudioMixer::TransitionToSnapshotInternal");
			AudioMixer.TransitionToSnapshotsDelegateField = IL2CPP.ResolveICall<AudioMixer.TransitionToSnapshotsDelegate>("UnityEngine.Audio.AudioMixer::TransitionToSnapshots");
			AudioMixer.get_updateModeDelegateField = IL2CPP.ResolveICall<AudioMixer.get_updateModeDelegate>("UnityEngine.Audio.AudioMixer::get_updateMode");
			AudioMixer.set_updateModeDelegateField = IL2CPP.ResolveICall<AudioMixer.set_updateModeDelegate>("UnityEngine.Audio.AudioMixer::set_updateMode");
			AudioMixer.ClearFloatDelegateField = IL2CPP.ResolveICall<AudioMixer.ClearFloatDelegate>("UnityEngine.Audio.AudioMixer::ClearFloat");
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00006850 File Offset: 0x00004A50
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 485474, RefRangeEnd = 485511, XrefRangeStart = 485470, XrefRangeEnd = 485474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetFloat(string name, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioMixer.NativeMethodInfoPtr_SetFloat_Public_Boolean_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x000068AC File Offset: 0x00004AAC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 485515, RefRangeEnd = 485518, XrefRangeStart = 485511, XrefRangeEnd = 485515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetFloat(string name, out float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioMixer.NativeMethodInfoPtr_GetFloat_Public_Boolean_String_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0000276A File Offset: 0x0000096A
		public AudioMixer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00006908 File Offset: 0x00004B08
		// (set) Token: 0x06000113 RID: 275 RVA: 0x00002773 File Offset: 0x00000973
		public AudioMixerGroup outputAudioMixerGroup
		{
			get
			{
				IntPtr intPtr = AudioMixer.get_outputAudioMixerGroupDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixerGroup>(intPtr2) : null;
			}
			set
			{
				AudioMixer.set_outputAudioMixerGroupDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00006934 File Offset: 0x00004B34
		public AudioMixerSnapshot FindSnapshot(string name)
		{
			IntPtr intPtr = AudioMixer.FindSnapshotDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixerSnapshot>(intPtr2) : null;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00006968 File Offset: 0x00004B68
		public Il2CppReferenceArray<AudioMixerGroup> FindMatchingGroups(string subPath)
		{
			IntPtr intPtr = AudioMixer.FindMatchingGroupsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(subPath));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioMixerGroup>>(intPtr2) : null;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0000278B File Offset: 0x0000098B
		public void TransitionToSnapshot(AudioMixerSnapshot snapshot, float timeToReach)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002798 File Offset: 0x00000998
		public void TransitionToSnapshotInternal(AudioMixerSnapshot snapshot, float timeToReach)
		{
			AudioMixer.TransitionToSnapshotInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(snapshot), timeToReach);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x000027B1 File Offset: 0x000009B1
		public void TransitionToSnapshots(Il2CppReferenceArray<AudioMixerSnapshot> snapshots, Il2CppStructArray<float> weights, float timeToReach)
		{
			AudioMixer.TransitionToSnapshotsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(snapshots), IL2CPP.Il2CppObjectBaseToPtr(weights), timeToReach);
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000119 RID: 281 RVA: 0x000027D0 File Offset: 0x000009D0
		// (set) Token: 0x0600011A RID: 282 RVA: 0x000027E2 File Offset: 0x000009E2
		public AudioMixerUpdateMode updateMode
		{
			get
			{
				return AudioMixer.get_updateModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioMixer.set_updateModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x000027F5 File Offset: 0x000009F5
		public bool ClearFloat(string name)
		{
			return AudioMixer.ClearFloatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeMethodInfoPtr_SetFloat_Public_Boolean_String_Single_0;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeMethodInfoPtr_GetFloat_Public_Boolean_String_byref_Single_0;

		// Token: 0x040000FC RID: 252
		private static readonly AudioMixer.get_outputAudioMixerGroupDelegate get_outputAudioMixerGroupDelegateField;

		// Token: 0x040000FD RID: 253
		private static readonly AudioMixer.set_outputAudioMixerGroupDelegate set_outputAudioMixerGroupDelegateField;

		// Token: 0x040000FE RID: 254
		private static readonly AudioMixer.FindSnapshotDelegate FindSnapshotDelegateField;

		// Token: 0x040000FF RID: 255
		private static readonly AudioMixer.FindMatchingGroupsDelegate FindMatchingGroupsDelegateField;

		// Token: 0x04000100 RID: 256
		private static readonly AudioMixer.TransitionToSnapshotInternalDelegate TransitionToSnapshotInternalDelegateField;

		// Token: 0x04000101 RID: 257
		private static readonly AudioMixer.TransitionToSnapshotsDelegate TransitionToSnapshotsDelegateField;

		// Token: 0x04000102 RID: 258
		private static readonly AudioMixer.get_updateModeDelegate get_updateModeDelegateField;

		// Token: 0x04000103 RID: 259
		private static readonly AudioMixer.set_updateModeDelegate set_updateModeDelegateField;

		// Token: 0x04000104 RID: 260
		private static readonly AudioMixer.ClearFloatDelegate ClearFloatDelegateField;

		// Token: 0x0200007A RID: 122
		// (Invoke) Token: 0x060002BA RID: 698
		private delegate IntPtr get_outputAudioMixerGroupDelegate(IntPtr @this);

		// Token: 0x0200007B RID: 123
		// (Invoke) Token: 0x060002BC RID: 700
		private delegate void set_outputAudioMixerGroupDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200007C RID: 124
		// (Invoke) Token: 0x060002BE RID: 702
		private delegate IntPtr FindSnapshotDelegate(IntPtr @this, IntPtr name);

		// Token: 0x0200007D RID: 125
		// (Invoke) Token: 0x060002C0 RID: 704
		private delegate IntPtr FindMatchingGroupsDelegate(IntPtr @this, IntPtr subPath);

		// Token: 0x0200007E RID: 126
		// (Invoke) Token: 0x060002C2 RID: 706
		private delegate void TransitionToSnapshotInternalDelegate(IntPtr @this, IntPtr snapshot, float timeToReach);

		// Token: 0x0200007F RID: 127
		// (Invoke) Token: 0x060002C4 RID: 708
		private delegate void TransitionToSnapshotsDelegate(IntPtr @this, IntPtr snapshots, IntPtr weights, float timeToReach);

		// Token: 0x02000080 RID: 128
		// (Invoke) Token: 0x060002C6 RID: 710
		private delegate AudioMixerUpdateMode get_updateModeDelegate(IntPtr @this);

		// Token: 0x02000081 RID: 129
		// (Invoke) Token: 0x060002C8 RID: 712
		private delegate void set_updateModeDelegate(IntPtr @this, AudioMixerUpdateMode value);

		// Token: 0x02000082 RID: 130
		// (Invoke) Token: 0x060002CA RID: 714
		private delegate bool ClearFloatDelegate(IntPtr @this, IntPtr name);
	}
}
