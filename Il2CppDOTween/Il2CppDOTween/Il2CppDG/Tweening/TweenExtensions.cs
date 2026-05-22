using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2CppDG.Tweening
{
	// Token: 0x02000012 RID: 18
	public static class TweenExtensions : global::Il2CppSystem.Object
	{
		// Token: 0x060000B5 RID: 181 RVA: 0x00008880 File Offset: 0x00006A80
		// Note: this type is marked as 'beforefieldinit'.
		static TweenExtensions()
		{
			Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening", "TweenExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr);
			TweenExtensions.NativeMethodInfoPtr_Complete_Public_Static_Void_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663410);
			TweenExtensions.NativeMethodInfoPtr_Complete_Public_Static_Void_Tween_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663411);
			TweenExtensions.NativeMethodInfoPtr_Flip_Public_Static_Void_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663412);
			TweenExtensions.NativeMethodInfoPtr_ForceInit_Public_Static_Void_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663413);
			TweenExtensions.NativeMethodInfoPtr_Goto_Public_Static_Void_Tween_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663414);
			TweenExtensions.NativeMethodInfoPtr_Kill_Public_Static_Void_Tween_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663415);
			TweenExtensions.NativeMethodInfoPtr_Pause_Public_Static_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663416);
			TweenExtensions.NativeMethodInfoPtr_Play_Public_Static_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663417);
			TweenExtensions.NativeMethodInfoPtr_PlayBackwards_Public_Static_Void_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663418);
			TweenExtensions.NativeMethodInfoPtr_PlayForward_Public_Static_Void_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663419);
			TweenExtensions.NativeMethodInfoPtr_Restart_Public_Static_Void_Tween_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663420);
			TweenExtensions.NativeMethodInfoPtr_Rewind_Public_Static_Void_Tween_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663421);
			TweenExtensions.NativeMethodInfoPtr_SmoothRewind_Public_Static_Void_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663422);
			TweenExtensions.NativeMethodInfoPtr_TogglePause_Public_Static_Void_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663423);
			TweenExtensions.NativeMethodInfoPtr_GotoWaypoint_Public_Static_Void_Tween_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663424);
			TweenExtensions.NativeMethodInfoPtr_WaitForCompletion_Public_Static_YieldInstruction_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663425);
			TweenExtensions.NativeMethodInfoPtr_WaitForRewind_Public_Static_YieldInstruction_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663426);
			TweenExtensions.NativeMethodInfoPtr_WaitForKill_Public_Static_YieldInstruction_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663427);
			TweenExtensions.NativeMethodInfoPtr_WaitForElapsedLoops_Public_Static_YieldInstruction_Tween_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663428);
			TweenExtensions.NativeMethodInfoPtr_WaitForPosition_Public_Static_YieldInstruction_Tween_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663429);
			TweenExtensions.NativeMethodInfoPtr_WaitForStart_Public_Static_Coroutine_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663430);
			TweenExtensions.NativeMethodInfoPtr_CompletedLoops_Public_Static_Int32_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663431);
			TweenExtensions.NativeMethodInfoPtr_Delay_Public_Static_Single_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663432);
			TweenExtensions.NativeMethodInfoPtr_Duration_Public_Static_Single_Tween_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663433);
			TweenExtensions.NativeMethodInfoPtr_Elapsed_Public_Static_Single_Tween_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663434);
			TweenExtensions.NativeMethodInfoPtr_ElapsedPercentage_Public_Static_Single_Tween_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663435);
			TweenExtensions.NativeMethodInfoPtr_ElapsedDirectionalPercentage_Public_Static_Single_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663436);
			TweenExtensions.NativeMethodInfoPtr_IsActive_Public_Static_Boolean_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663437);
			TweenExtensions.NativeMethodInfoPtr_IsBackwards_Public_Static_Boolean_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663438);
			TweenExtensions.NativeMethodInfoPtr_IsComplete_Public_Static_Boolean_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663439);
			TweenExtensions.NativeMethodInfoPtr_IsInitialized_Public_Static_Boolean_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663440);
			TweenExtensions.NativeMethodInfoPtr_IsPlaying_Public_Static_Boolean_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663441);
			TweenExtensions.NativeMethodInfoPtr_Loops_Public_Static_Int32_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663442);
			TweenExtensions.NativeMethodInfoPtr_PathGetPoint_Public_Static_Vector3_Tween_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663443);
			TweenExtensions.NativeMethodInfoPtr_PathGetDrawPoints_Public_Static_Il2CppStructArray_1_Vector3_Tween_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663444);
			TweenExtensions.NativeMethodInfoPtr_PathLength_Public_Static_Single_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663445);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00008B80 File Offset: 0x00006D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118951, XrefRangeEnd = 118970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Complete(this Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_Complete_Public_Static_Void_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00008BB8 File Offset: 0x00006DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118970, XrefRangeEnd = 118990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Complete(this Tween t, bool withCallbacks)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref withCallbacks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_Complete_Public_Static_Void_Tween_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00008BFC File Offset: 0x00006DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118990, XrefRangeEnd = 118994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Flip(this Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_Flip_Public_Static_Void_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00008C34 File Offset: 0x00006E34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118994, XrefRangeEnd = 119011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ForceInit(this Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_ForceInit_Public_Static_Void_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00008C6C File Offset: 0x00006E6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 119016, RefRangeEnd = 119017, XrefRangeStart = 119011, XrefRangeEnd = 119016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Goto(this Tween t, float to, bool andPlay = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref andPlay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_Goto_Public_Static_Void_Tween_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00008CC0 File Offset: 0x00006EC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119017, XrefRangeEnd = 119027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Kill(this Tween t, bool complete = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref complete;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_Kill_Public_Static_Void_Tween_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00008D04 File Offset: 0x00006F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119027, XrefRangeEnd = 119032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Pause<T>(this T t) where T : Tween
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					if (!(t2 is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
					}
				}
				else
				{
					ptr4 = ref t;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.MethodInfoStoreGeneric_Pause_Public_Static_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00008D90 File Offset: 0x00006F90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119032, XrefRangeEnd = 119036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Play<T>(this T t) where T : Tween
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					if (!(t2 is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
					}
				}
				else
				{
					ptr4 = ref t;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.MethodInfoStoreGeneric_Play_Public_Static_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00008E1C File Offset: 0x0000701C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119036, XrefRangeEnd = 119053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PlayBackwards(this Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_PlayBackwards_Public_Static_Void_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00008E54 File Offset: 0x00007054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119053, XrefRangeEnd = 119070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PlayForward(this Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_PlayForward_Public_Static_Void_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00008E8C File Offset: 0x0000708C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119070, XrefRangeEnd = 119087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Restart(this Tween t, bool includeDelay = true, float changeDelayTo = -1f)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeDelay;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref changeDelayTo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_Restart_Public_Static_Void_Tween_Boolean_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00008EE0 File Offset: 0x000070E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119087, XrefRangeEnd = 119104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Rewind(this Tween t, bool includeDelay = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeDelay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_Rewind_Public_Static_Void_Tween_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00008F24 File Offset: 0x00007124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119104, XrefRangeEnd = 119121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SmoothRewind(this Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_SmoothRewind_Public_Static_Void_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00008F5C File Offset: 0x0000715C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119121, XrefRangeEnd = 119138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TogglePause(this Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_TogglePause_Public_Static_Void_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00008F94 File Offset: 0x00007194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119138, XrefRangeEnd = 119150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GotoWaypoint(this Tween t, int waypointIndex, bool andPlay = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref waypointIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref andPlay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_GotoWaypoint_Public_Static_Void_Tween_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00008FE8 File Offset: 0x000071E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119150, XrefRangeEnd = 119163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static YieldInstruction WaitForCompletion(this Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_WaitForCompletion_Public_Static_YieldInstruction_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<YieldInstruction>(intPtr3) : null;
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000902C File Offset: 0x0000722C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119163, XrefRangeEnd = 119176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static YieldInstruction WaitForRewind(this Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_WaitForRewind_Public_Static_YieldInstruction_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<YieldInstruction>(intPtr3) : null;
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00009070 File Offset: 0x00007270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119176, XrefRangeEnd = 119189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static YieldInstruction WaitForKill(this Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_WaitForKill_Public_Static_YieldInstruction_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<YieldInstruction>(intPtr3) : null;
			}
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000090B4 File Offset: 0x000072B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119189, XrefRangeEnd = 119202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static YieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedLoops;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_WaitForElapsedLoops_Public_Static_YieldInstruction_Tween_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<YieldInstruction>(intPtr3) : null;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00009108 File Offset: 0x00007308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119202, XrefRangeEnd = 119215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static YieldInstruction WaitForPosition(this Tween t, float position)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_WaitForPosition_Public_Static_YieldInstruction_Tween_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<YieldInstruction>(intPtr3) : null;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000915C File Offset: 0x0000735C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119215, XrefRangeEnd = 119228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Coroutine WaitForStart(this Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_WaitForStart_Public_Static_Coroutine_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr3) : null;
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x000091A0 File Offset: 0x000073A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119228, XrefRangeEnd = 119229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CompletedLoops(this Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_CompletedLoops_Public_Static_Int32_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000091E4 File Offset: 0x000073E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119229, XrefRangeEnd = 119230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Delay(this Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_Delay_Public_Static_Single_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00009228 File Offset: 0x00007428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119230, XrefRangeEnd = 119231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Duration(this Tween t, bool includeLoops = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeLoops;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_Duration_Public_Static_Single_Tween_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00009278 File Offset: 0x00007478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119231, XrefRangeEnd = 119232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Elapsed(this Tween t, bool includeLoops = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeLoops;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_Elapsed_Public_Static_Single_Tween_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x000092C8 File Offset: 0x000074C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 119233, RefRangeEnd = 119236, XrefRangeStart = 119232, XrefRangeEnd = 119233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ElapsedPercentage(this Tween t, bool includeLoops = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeLoops;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_ElapsedPercentage_Public_Static_Single_Tween_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00009318 File Offset: 0x00007518
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 119237, RefRangeEnd = 119239, XrefRangeStart = 119236, XrefRangeEnd = 119237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ElapsedDirectionalPercentage(this Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_ElapsedDirectionalPercentage_Public_Static_Single_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000935C File Offset: 0x0000755C
		[CallerCount(0)]
		public unsafe static bool IsActive(this Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_IsActive_Public_Static_Boolean_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000093A0 File Offset: 0x000075A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119239, XrefRangeEnd = 119240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsBackwards(this Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_IsBackwards_Public_Static_Boolean_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000093E4 File Offset: 0x000075E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119240, XrefRangeEnd = 119241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsComplete(this Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_IsComplete_Public_Static_Boolean_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00009428 File Offset: 0x00007628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119241, XrefRangeEnd = 119242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsInitialized(this Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_IsInitialized_Public_Static_Boolean_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000946C File Offset: 0x0000766C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119242, XrefRangeEnd = 119243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPlaying(this Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_IsPlaying_Public_Static_Boolean_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000094B0 File Offset: 0x000076B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119243, XrefRangeEnd = 119244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Loops(this Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_Loops_Public_Static_Int32_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x000094F4 File Offset: 0x000076F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119244, XrefRangeEnd = 119272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 PathGetPoint(this Tween t, float pathPercentage)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pathPercentage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_PathGetPoint_Public_Static_Vector3_Tween_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00009544 File Offset: 0x00007744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119272, XrefRangeEnd = 119299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<Vector3> PathGetDrawPoints(this Tween t, int subdivisionsXSegment = 10)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref subdivisionsXSegment;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_PathGetDrawPoints_Public_Static_Il2CppStructArray_1_Vector3_Tween_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr3) : null;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00009598 File Offset: 0x00007798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119299, XrefRangeEnd = 119303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float PathLength(this Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_PathLength_Public_Static_Single_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000022CA File Offset: 0x000004CA
		public TweenExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Static_Void_Tween_0;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Static_Void_Tween_Boolean_0;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeMethodInfoPtr_Flip_Public_Static_Void_Tween_0;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr_ForceInit_Public_Static_Void_Tween_0;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeMethodInfoPtr_Goto_Public_Static_Void_Tween_Single_Boolean_0;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeMethodInfoPtr_Kill_Public_Static_Void_Tween_Boolean_0;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Static_T_T_0;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Static_T_T_0;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeMethodInfoPtr_PlayBackwards_Public_Static_Void_Tween_0;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeMethodInfoPtr_PlayForward_Public_Static_Void_Tween_0;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeMethodInfoPtr_Restart_Public_Static_Void_Tween_Boolean_Single_0;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeMethodInfoPtr_Rewind_Public_Static_Void_Tween_Boolean_0;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeMethodInfoPtr_SmoothRewind_Public_Static_Void_Tween_0;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeMethodInfoPtr_TogglePause_Public_Static_Void_Tween_0;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeMethodInfoPtr_GotoWaypoint_Public_Static_Void_Tween_Int32_Boolean_0;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeMethodInfoPtr_WaitForCompletion_Public_Static_YieldInstruction_Tween_0;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeMethodInfoPtr_WaitForRewind_Public_Static_YieldInstruction_Tween_0;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeMethodInfoPtr_WaitForKill_Public_Static_YieldInstruction_Tween_0;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeMethodInfoPtr_WaitForElapsedLoops_Public_Static_YieldInstruction_Tween_Int32_0;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeMethodInfoPtr_WaitForPosition_Public_Static_YieldInstruction_Tween_Single_0;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr_WaitForStart_Public_Static_Coroutine_Tween_0;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeMethodInfoPtr_CompletedLoops_Public_Static_Int32_Tween_0;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeMethodInfoPtr_Delay_Public_Static_Single_Tween_0;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeMethodInfoPtr_Duration_Public_Static_Single_Tween_Boolean_0;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeMethodInfoPtr_Elapsed_Public_Static_Single_Tween_Boolean_0;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeMethodInfoPtr_ElapsedPercentage_Public_Static_Single_Tween_Boolean_0;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeMethodInfoPtr_ElapsedDirectionalPercentage_Public_Static_Single_Tween_0;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeMethodInfoPtr_IsActive_Public_Static_Boolean_Tween_0;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeMethodInfoPtr_IsBackwards_Public_Static_Boolean_Tween_0;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeMethodInfoPtr_IsComplete_Public_Static_Boolean_Tween_0;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeMethodInfoPtr_IsInitialized_Public_Static_Boolean_Tween_0;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeMethodInfoPtr_IsPlaying_Public_Static_Boolean_Tween_0;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeMethodInfoPtr_Loops_Public_Static_Int32_Tween_0;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeMethodInfoPtr_PathGetPoint_Public_Static_Vector3_Tween_Single_0;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeMethodInfoPtr_PathGetDrawPoints_Public_Static_Il2CppStructArray_1_Vector3_Tween_Int32_0;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeMethodInfoPtr_PathLength_Public_Static_Single_Tween_0;

		// Token: 0x02000066 RID: 102
		private sealed class MethodInfoStoreGeneric_Pause_Public_Static_T_T_0<T>
		{
			// Token: 0x040004B6 RID: 1206
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenExtensions.NativeMethodInfoPtr_Pause_Public_Static_T_T_0, Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000067 RID: 103
		private sealed class MethodInfoStoreGeneric_Play_Public_Static_T_T_0<T>
		{
			// Token: 0x040004B7 RID: 1207
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenExtensions.NativeMethodInfoPtr_Play_Public_Static_T_T_0, Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
