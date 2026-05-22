using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Audio
{
	// Token: 0x02000013 RID: 19
	public static class AudioPlayableBinding : Object
	{
		// Token: 0x0600012E RID: 302 RVA: 0x00006D6C File Offset: 0x00004F6C
		// Note: this type is marked as 'beforefieldinit'.
		static AudioPlayableBinding()
		{
			Il2CppClassPointerStore<AudioPlayableBinding>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AudioModule.dll", "UnityEngine.Audio", "AudioPlayableBinding");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioPlayableBinding>.NativeClassPtr);
			AudioPlayableBinding.NativeMethodInfoPtr_Create_Public_Static_PlayableBinding_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPlayableBinding>.NativeClassPtr, 100663438);
			AudioPlayableBinding.NativeMethodInfoPtr_CreateAudioOutput_Private_Static_PlayableOutput_PlayableGraph_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPlayableBinding>.NativeClassPtr, 100663439);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00006DC4 File Offset: 0x00004FC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 485593, RefRangeEnd = 485595, XrefRangeStart = 485578, XrefRangeEnd = 485593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PlayableBinding Create(string name, Object key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioPlayableBinding.NativeMethodInfoPtr_Create_Public_Static_PlayableBinding_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new PlayableBinding(intPtr);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00006E14 File Offset: 0x00005014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485595, XrefRangeEnd = 485596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PlayableOutput CreateAudioOutput(PlayableGraph graph, string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioPlayableBinding.NativeMethodInfoPtr_CreateAudioOutput_Private_Static_PlayableOutput_PlayableGraph_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00002876 File Offset: 0x00000A76
		public AudioPlayableBinding(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_PlayableBinding_String_Object_0;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeMethodInfoPtr_CreateAudioOutput_Private_Static_PlayableOutput_PlayableGraph_String_0;
	}
}
