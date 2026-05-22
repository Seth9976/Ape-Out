using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Animations
{
	// Token: 0x02000018 RID: 24
	public static class AnimationPlayableBinding : Object
	{
		// Token: 0x060002A4 RID: 676 RVA: 0x0000A65C File Offset: 0x0000885C
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationPlayableBinding()
		{
			Il2CppClassPointerStore<AnimationPlayableBinding>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "AnimationPlayableBinding");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationPlayableBinding>.NativeClassPtr);
			AnimationPlayableBinding.NativeMethodInfoPtr_Create_Public_Static_PlayableBinding_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableBinding>.NativeClassPtr, 100663371);
			AnimationPlayableBinding.NativeMethodInfoPtr_CreateAnimationOutput_Private_Static_PlayableOutput_PlayableGraph_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableBinding>.NativeClassPtr, 100663372);
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0000A6B4 File Offset: 0x000088B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 483967, RefRangeEnd = 483969, XrefRangeStart = 483952, XrefRangeEnd = 483967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableBinding.NativeMethodInfoPtr_Create_Public_Static_PlayableBinding_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new PlayableBinding(intPtr);
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0000A704 File Offset: 0x00008904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483969, XrefRangeEnd = 483970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PlayableOutput CreateAnimationOutput(PlayableGraph graph, string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableBinding.NativeMethodInfoPtr_CreateAnimationOutput_Private_Static_PlayableOutput_PlayableGraph_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00003B29 File Offset: 0x00001D29
		public AnimationPlayableBinding(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_PlayableBinding_String_Object_0;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeMethodInfoPtr_CreateAnimationOutput_Private_Static_PlayableOutput_PlayableGraph_String_0;
	}
}
