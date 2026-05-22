using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000044 RID: 68
	public class SECTR_PropagationSource : SECTR_AudioSource
	{
		// Token: 0x06000A8B RID: 2699 RVA: 0x000534F0 File Offset: 0x000516F0
		// Note: this type is marked as 'beforefieldinit'.
		static SECTR_PropagationSource()
		{
			Il2CppClassPointerStore<SECTR_PropagationSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SECTR_PropagationSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_PropagationSource>.NativeClassPtr);
			SECTR_PropagationSource.NativeFieldInfoPtr_cachedMember = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_PropagationSource>.NativeClassPtr, "cachedMember");
			SECTR_PropagationSource.NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_PropagationSource>.NativeClassPtr, "path");
			SECTR_PropagationSource.NativeFieldInfoPtr_activeSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_PropagationSource>.NativeClassPtr, "activeSounds");
			SECTR_PropagationSource.NativeFieldInfoPtr_directDistanceToListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_PropagationSource>.NativeClassPtr, "directDistanceToListener");
			SECTR_PropagationSource.NativeFieldInfoPtr_playing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_PropagationSource>.NativeClassPtr, "playing");
			SECTR_PropagationSource.NativeFieldInfoPtr_played = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_PropagationSource>.NativeClassPtr, "played");
			SECTR_PropagationSource.NativeFieldInfoPtr_InterpDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_PropagationSource>.NativeClassPtr, "InterpDistance");
			SECTR_PropagationSource.NativeMethodInfoPtr_get_IsPlaying_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_PropagationSource>.NativeClassPtr, 100664170);
			SECTR_PropagationSource.NativeMethodInfoPtr_Play_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_PropagationSource>.NativeClassPtr, 100664171);
			SECTR_PropagationSource.NativeMethodInfoPtr_PlayAtTime_Public_Virtual_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_PropagationSource>.NativeClassPtr, 100664172);
			SECTR_PropagationSource.NativeMethodInfoPtr_Stop_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_PropagationSource>.NativeClassPtr, 100664173);
			SECTR_PropagationSource.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_PropagationSource>.NativeClassPtr, 100664174);
			SECTR_PropagationSource.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_PropagationSource>.NativeClassPtr, 100664175);
			SECTR_PropagationSource.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_PropagationSource>.NativeClassPtr, 100664176);
			SECTR_PropagationSource.NativeMethodInfoPtr_OnVolumePitchChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_PropagationSource>.NativeClassPtr, 100664177);
			SECTR_PropagationSource.NativeMethodInfoPtr__ComputeSoundSpatialization_Private_Void_Vector3_Single_PathSound_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_PropagationSource>.NativeClassPtr, 100664178);
			SECTR_PropagationSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_PropagationSource>.NativeClassPtr, 100664179);
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000A8C RID: 2700 RVA: 0x00053674 File Offset: 0x00051874
		public unsafe override bool IsPlaying
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40228, XrefRangeEnd = 40229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SECTR_PropagationSource.NativeMethodInfoPtr_get_IsPlaying_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x000536BC File Offset: 0x000518BC
		[CallerCount(0)]
		public unsafe override void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SECTR_PropagationSource.NativeMethodInfoPtr_Play_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x000536F8 File Offset: 0x000518F8
		[CallerCount(0)]
		public unsafe override void PlayAtTime(float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SECTR_PropagationSource.NativeMethodInfoPtr_PlayAtTime_Public_Virtual_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x00053744 File Offset: 0x00051944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40229, XrefRangeEnd = 40234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Stop(bool stopImmediately)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref stopImmediately;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SECTR_PropagationSource.NativeMethodInfoPtr_Stop_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x00053790 File Offset: 0x00051990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40234, XrefRangeEnd = 40237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_PropagationSource.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x000537C4 File Offset: 0x000519C4
		[CallerCount(0)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SECTR_PropagationSource.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x00053800 File Offset: 0x00051A00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40237, XrefRangeEnd = 40275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_PropagationSource.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x00053834 File Offset: 0x00051A34
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnVolumePitchChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SECTR_PropagationSource.NativeMethodInfoPtr_OnVolumePitchChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x00053870 File Offset: 0x00051A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40275, XrefRangeEnd = 40309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ComputeSoundSpatialization(Vector3 listenerPosition, float distanceToListener, SECTR_PropagationSource.PathSound pathSound)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref listenerPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distanceToListener;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pathSound);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_PropagationSource.NativeMethodInfoPtr__ComputeSoundSpatialization_Private_Void_Vector3_Single_PathSound_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x000538D0 File Offset: 0x00051AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40309, XrefRangeEnd = 40328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_PropagationSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_PropagationSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_PropagationSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x00008A15 File Offset: 0x00006C15
		public SECTR_PropagationSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000A97 RID: 2711 RVA: 0x0005390C File Offset: 0x00051B0C
		// (set) Token: 0x06000A98 RID: 2712 RVA: 0x00008A1E File Offset: 0x00006C1E
		public unsafe SECTR_Member cachedMember
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_PropagationSource.NativeFieldInfoPtr_cachedMember);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_Member>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_PropagationSource.NativeFieldInfoPtr_cachedMember), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000A99 RID: 2713 RVA: 0x0005393C File Offset: 0x00051B3C
		// (set) Token: 0x06000A9A RID: 2714 RVA: 0x00008A3D File Offset: 0x00006C3D
		public unsafe List<SECTR_Graph.Node> path
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_PropagationSource.NativeFieldInfoPtr_path);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SECTR_Graph.Node>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_PropagationSource.NativeFieldInfoPtr_path), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000A9B RID: 2715 RVA: 0x0005396C File Offset: 0x00051B6C
		// (set) Token: 0x06000A9C RID: 2716 RVA: 0x00008A5C File Offset: 0x00006C5C
		public unsafe List<SECTR_PropagationSource.PathSound> activeSounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_PropagationSource.NativeFieldInfoPtr_activeSounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SECTR_PropagationSource.PathSound>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_PropagationSource.NativeFieldInfoPtr_activeSounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000A9D RID: 2717 RVA: 0x0005399C File Offset: 0x00051B9C
		// (set) Token: 0x06000A9E RID: 2718 RVA: 0x00008A7B File Offset: 0x00006C7B
		public unsafe float directDistanceToListener
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_PropagationSource.NativeFieldInfoPtr_directDistanceToListener);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_PropagationSource.NativeFieldInfoPtr_directDistanceToListener)) = value;
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000A9F RID: 2719 RVA: 0x000539C4 File Offset: 0x00051BC4
		// (set) Token: 0x06000AA0 RID: 2720 RVA: 0x00008A96 File Offset: 0x00006C96
		public unsafe bool playing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_PropagationSource.NativeFieldInfoPtr_playing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_PropagationSource.NativeFieldInfoPtr_playing)) = value;
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000AA1 RID: 2721 RVA: 0x000539EC File Offset: 0x00051BEC
		// (set) Token: 0x06000AA2 RID: 2722 RVA: 0x00008AB1 File Offset: 0x00006CB1
		public unsafe bool played
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_PropagationSource.NativeFieldInfoPtr_played);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_PropagationSource.NativeFieldInfoPtr_played)) = value;
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000AA3 RID: 2723 RVA: 0x00053A14 File Offset: 0x00051C14
		// (set) Token: 0x06000AA4 RID: 2724 RVA: 0x00008ACC File Offset: 0x00006CCC
		public unsafe float InterpDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_PropagationSource.NativeFieldInfoPtr_InterpDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_PropagationSource.NativeFieldInfoPtr_InterpDistance)) = value;
			}
		}

		// Token: 0x04000666 RID: 1638
		private static readonly IntPtr NativeFieldInfoPtr_cachedMember;

		// Token: 0x04000667 RID: 1639
		private static readonly IntPtr NativeFieldInfoPtr_path;

		// Token: 0x04000668 RID: 1640
		private static readonly IntPtr NativeFieldInfoPtr_activeSounds;

		// Token: 0x04000669 RID: 1641
		private static readonly IntPtr NativeFieldInfoPtr_directDistanceToListener;

		// Token: 0x0400066A RID: 1642
		private static readonly IntPtr NativeFieldInfoPtr_playing;

		// Token: 0x0400066B RID: 1643
		private static readonly IntPtr NativeFieldInfoPtr_played;

		// Token: 0x0400066C RID: 1644
		private static readonly IntPtr NativeFieldInfoPtr_InterpDistance;

		// Token: 0x0400066D RID: 1645
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPlaying_Public_Virtual_get_Boolean_0;

		// Token: 0x0400066E RID: 1646
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Virtual_Void_0;

		// Token: 0x0400066F RID: 1647
		private static readonly IntPtr NativeMethodInfoPtr_PlayAtTime_Public_Virtual_Void_Single_0;

		// Token: 0x04000670 RID: 1648
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Virtual_Void_Boolean_0;

		// Token: 0x04000671 RID: 1649
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000672 RID: 1650
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x04000673 RID: 1651
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000674 RID: 1652
		private static readonly IntPtr NativeMethodInfoPtr_OnVolumePitchChanged_Protected_Virtual_Void_0;

		// Token: 0x04000675 RID: 1653
		private static readonly IntPtr NativeMethodInfoPtr__ComputeSoundSpatialization_Private_Void_Vector3_Single_PathSound_0;

		// Token: 0x04000676 RID: 1654
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002BC RID: 700
		public class PathSound : global::Il2CppSystem.Object
		{
			// Token: 0x06004B96 RID: 19350 RVA: 0x0011763C File Offset: 0x0011583C
			// Note: this type is marked as 'beforefieldinit'.
			static PathSound()
			{
				Il2CppClassPointerStore<SECTR_PropagationSource.PathSound>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SECTR_PropagationSource>.NativeClassPtr, "PathSound");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_PropagationSource.PathSound>.NativeClassPtr);
				SECTR_PropagationSource.PathSound.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_PropagationSource.PathSound>.NativeClassPtr, "instance");
				SECTR_PropagationSource.PathSound.NativeFieldInfoPtr_firstPortal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_PropagationSource.PathSound>.NativeClassPtr, "firstPortal");
				SECTR_PropagationSource.PathSound.NativeFieldInfoPtr_secondPortal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_PropagationSource.PathSound>.NativeClassPtr, "secondPortal");
				SECTR_PropagationSource.PathSound.NativeFieldInfoPtr_firstDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_PropagationSource.PathSound>.NativeClassPtr, "firstDistance");
				SECTR_PropagationSource.PathSound.NativeFieldInfoPtr_secondDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_PropagationSource.PathSound>.NativeClassPtr, "secondDistance");
				SECTR_PropagationSource.PathSound.NativeFieldInfoPtr_distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_PropagationSource.PathSound>.NativeClassPtr, "distance");
				SECTR_PropagationSource.PathSound.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_PropagationSource.PathSound>.NativeClassPtr, "position");
				SECTR_PropagationSource.PathSound.NativeFieldInfoPtr_lastListenerPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_PropagationSource.PathSound>.NativeClassPtr, "lastListenerPosition");
				SECTR_PropagationSource.PathSound.NativeFieldInfoPtr_weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_PropagationSource.PathSound>.NativeClassPtr, "weight");
				SECTR_PropagationSource.PathSound.NativeFieldInfoPtr_occluded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_PropagationSource.PathSound>.NativeClassPtr, "occluded");
				SECTR_PropagationSource.PathSound.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_PropagationSource.PathSound>.NativeClassPtr, 100664180);
			}

			// Token: 0x06004B97 RID: 19351 RVA: 0x00117744 File Offset: 0x00115944
			[CallerCount(0)]
			public unsafe PathSound()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_PropagationSource.PathSound>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_PropagationSource.PathSound.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004B98 RID: 19352 RVA: 0x0002C6B4 File Offset: 0x0002A8B4
			public PathSound(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B84 RID: 7044
			// (get) Token: 0x06004B99 RID: 19353 RVA: 0x00117780 File Offset: 0x00115980
			// (set) Token: 0x06004B9A RID: 19354 RVA: 0x0002C6BD File Offset: 0x0002A8BD
			public SECTR_AudioCueInstance instance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_PropagationSource.PathSound.NativeFieldInfoPtr_instance);
					return new SECTR_AudioCueInstance(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_PropagationSource.PathSound.NativeFieldInfoPtr_instance), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001B85 RID: 7045
			// (get) Token: 0x06004B9B RID: 19355 RVA: 0x001177B0 File Offset: 0x001159B0
			// (set) Token: 0x06004B9C RID: 19356 RVA: 0x0002C6EB File Offset: 0x0002A8EB
			public unsafe SECTR_Portal firstPortal
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_PropagationSource.PathSound.NativeFieldInfoPtr_firstPortal);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_Portal>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_PropagationSource.PathSound.NativeFieldInfoPtr_firstPortal), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B86 RID: 7046
			// (get) Token: 0x06004B9D RID: 19357 RVA: 0x001177E0 File Offset: 0x001159E0
			// (set) Token: 0x06004B9E RID: 19358 RVA: 0x0002C70A File Offset: 0x0002A90A
			public unsafe SECTR_Portal secondPortal
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_PropagationSource.PathSound.NativeFieldInfoPtr_secondPortal);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_Portal>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_PropagationSource.PathSound.NativeFieldInfoPtr_secondPortal), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B87 RID: 7047
			// (get) Token: 0x06004B9F RID: 19359 RVA: 0x00117810 File Offset: 0x00115A10
			// (set) Token: 0x06004BA0 RID: 19360 RVA: 0x0002C729 File Offset: 0x0002A929
			public unsafe float firstDistance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_PropagationSource.PathSound.NativeFieldInfoPtr_firstDistance);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_PropagationSource.PathSound.NativeFieldInfoPtr_firstDistance)) = value;
				}
			}

			// Token: 0x17001B88 RID: 7048
			// (get) Token: 0x06004BA1 RID: 19361 RVA: 0x00117838 File Offset: 0x00115A38
			// (set) Token: 0x06004BA2 RID: 19362 RVA: 0x0002C744 File Offset: 0x0002A944
			public unsafe float secondDistance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_PropagationSource.PathSound.NativeFieldInfoPtr_secondDistance);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_PropagationSource.PathSound.NativeFieldInfoPtr_secondDistance)) = value;
				}
			}

			// Token: 0x17001B89 RID: 7049
			// (get) Token: 0x06004BA3 RID: 19363 RVA: 0x00117860 File Offset: 0x00115A60
			// (set) Token: 0x06004BA4 RID: 19364 RVA: 0x0002C75F File Offset: 0x0002A95F
			public unsafe float distance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_PropagationSource.PathSound.NativeFieldInfoPtr_distance);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_PropagationSource.PathSound.NativeFieldInfoPtr_distance)) = value;
				}
			}

			// Token: 0x17001B8A RID: 7050
			// (get) Token: 0x06004BA5 RID: 19365 RVA: 0x00117888 File Offset: 0x00115A88
			// (set) Token: 0x06004BA6 RID: 19366 RVA: 0x0002C77A File Offset: 0x0002A97A
			public unsafe Vector3 position
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_PropagationSource.PathSound.NativeFieldInfoPtr_position);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_PropagationSource.PathSound.NativeFieldInfoPtr_position)) = value;
				}
			}

			// Token: 0x17001B8B RID: 7051
			// (get) Token: 0x06004BA7 RID: 19367 RVA: 0x001178B0 File Offset: 0x00115AB0
			// (set) Token: 0x06004BA8 RID: 19368 RVA: 0x0002C795 File Offset: 0x0002A995
			public unsafe Vector3 lastListenerPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_PropagationSource.PathSound.NativeFieldInfoPtr_lastListenerPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_PropagationSource.PathSound.NativeFieldInfoPtr_lastListenerPosition)) = value;
				}
			}

			// Token: 0x17001B8C RID: 7052
			// (get) Token: 0x06004BA9 RID: 19369 RVA: 0x001178D8 File Offset: 0x00115AD8
			// (set) Token: 0x06004BAA RID: 19370 RVA: 0x0002C7B0 File Offset: 0x0002A9B0
			public unsafe float weight
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_PropagationSource.PathSound.NativeFieldInfoPtr_weight);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_PropagationSource.PathSound.NativeFieldInfoPtr_weight)) = value;
				}
			}

			// Token: 0x17001B8D RID: 7053
			// (get) Token: 0x06004BAB RID: 19371 RVA: 0x00117900 File Offset: 0x00115B00
			// (set) Token: 0x06004BAC RID: 19372 RVA: 0x0002C7CB File Offset: 0x0002A9CB
			public unsafe bool occluded
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_PropagationSource.PathSound.NativeFieldInfoPtr_occluded);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_PropagationSource.PathSound.NativeFieldInfoPtr_occluded)) = value;
				}
			}

			// Token: 0x04003191 RID: 12689
			private static readonly IntPtr NativeFieldInfoPtr_instance;

			// Token: 0x04003192 RID: 12690
			private static readonly IntPtr NativeFieldInfoPtr_firstPortal;

			// Token: 0x04003193 RID: 12691
			private static readonly IntPtr NativeFieldInfoPtr_secondPortal;

			// Token: 0x04003194 RID: 12692
			private static readonly IntPtr NativeFieldInfoPtr_firstDistance;

			// Token: 0x04003195 RID: 12693
			private static readonly IntPtr NativeFieldInfoPtr_secondDistance;

			// Token: 0x04003196 RID: 12694
			private static readonly IntPtr NativeFieldInfoPtr_distance;

			// Token: 0x04003197 RID: 12695
			private static readonly IntPtr NativeFieldInfoPtr_position;

			// Token: 0x04003198 RID: 12696
			private static readonly IntPtr NativeFieldInfoPtr_lastListenerPosition;

			// Token: 0x04003199 RID: 12697
			private static readonly IntPtr NativeFieldInfoPtr_weight;

			// Token: 0x0400319A RID: 12698
			private static readonly IntPtr NativeFieldInfoPtr_occluded;

			// Token: 0x0400319B RID: 12699
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
