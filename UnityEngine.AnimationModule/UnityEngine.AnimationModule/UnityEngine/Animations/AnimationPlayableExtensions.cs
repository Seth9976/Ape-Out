using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine.Playables;

namespace UnityEngine.Animations
{
	// Token: 0x02000021 RID: 33
	public static class AnimationPlayableExtensions : Object
	{
		// Token: 0x06000394 RID: 916 RVA: 0x0000C670 File Offset: 0x0000A870
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationPlayableExtensions()
		{
			Il2CppClassPointerStore<AnimationPlayableExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "AnimationPlayableExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationPlayableExtensions>.NativeClassPtr);
			AnimationPlayableExtensions.NativeMethodInfoPtr_SetAnimatedProperties_Public_Static_Void_U_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableExtensions>.NativeClassPtr, 100663430);
			AnimationPlayableExtensions.NativeMethodInfoPtr_SetAnimatedPropertiesInternal_Internal_Static_Void_byref_PlayableHandle_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableExtensions>.NativeClassPtr, 100663431);
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0000C6C8 File Offset: 0x0000A8C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484452, XrefRangeEnd = 484454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetAnimatedProperties<U>(this U playable, AnimationClip clip) where U : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref U ptr4;
				if (!typeof(U).IsValueType)
				{
					U u = playable;
					if (!(u is string))
					{
						ref U ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(u as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(u as string);
					}
				}
				else
				{
					ptr4 = ref playable;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clip);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableExtensions.MethodInfoStoreGeneric_SetAnimatedProperties_Public_Static_Void_U_AnimationClip_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000396 RID: 918 RVA: 0x0000C75C File Offset: 0x0000A95C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484454, XrefRangeEnd = 484458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetAnimatedPropertiesInternal(ref PlayableHandle playable, AnimationClip animatedProperties)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &playable;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(animatedProperties);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableExtensions.NativeMethodInfoPtr_SetAnimatedPropertiesInternal_Internal_Static_Void_byref_PlayableHandle_AnimationClip_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000397 RID: 919 RVA: 0x000041B1 File Offset: 0x000023B1
		public AnimationPlayableExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400021D RID: 541
		private static readonly IntPtr NativeMethodInfoPtr_SetAnimatedProperties_Public_Static_Void_U_AnimationClip_0;

		// Token: 0x0400021E RID: 542
		private static readonly IntPtr NativeMethodInfoPtr_SetAnimatedPropertiesInternal_Internal_Static_Void_byref_PlayableHandle_AnimationClip_0;

		// Token: 0x02000189 RID: 393
		private sealed class MethodInfoStoreGeneric_SetAnimatedProperties_Public_Static_Void_U_AnimationClip_0<U>
		{
			// Token: 0x04000439 RID: 1081
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AnimationPlayableExtensions.NativeMethodInfoPtr_SetAnimatedProperties_Public_Static_Void_U_AnimationClip_0, Il2CppClassPointerStore<AnimationPlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)) }))));
		}
	}
}
