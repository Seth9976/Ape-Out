using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Audio
{
	// Token: 0x02000014 RID: 20
	public static class AudioPlayableGraphExtensions : Object
	{
		// Token: 0x06000132 RID: 306 RVA: 0x0000287F File Offset: 0x00000A7F
		// Note: this type is marked as 'beforefieldinit'.
		static AudioPlayableGraphExtensions()
		{
			Il2CppClassPointerStore<AudioPlayableGraphExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AudioModule.dll", "UnityEngine.Audio", "AudioPlayableGraphExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioPlayableGraphExtensions>.NativeClassPtr);
			AudioPlayableGraphExtensions.NativeMethodInfoPtr_InternalCreateAudioOutput_Internal_Static_Boolean_byref_PlayableGraph_String_byref_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPlayableGraphExtensions>.NativeClassPtr, 100663440);
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00006E64 File Offset: 0x00005064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485596, XrefRangeEnd = 485600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InternalCreateAudioOutput(ref PlayableGraph graph, string name, out PlayableOutputHandle handle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &handle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioPlayableGraphExtensions.NativeMethodInfoPtr_InternalCreateAudioOutput_Internal_Static_Boolean_byref_PlayableGraph_String_byref_PlayableOutputHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x000028B8 File Offset: 0x00000AB8
		public AudioPlayableGraphExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeMethodInfoPtr_InternalCreateAudioOutput_Internal_Static_Boolean_byref_PlayableGraph_String_byref_PlayableOutputHandle_0;
	}
}
