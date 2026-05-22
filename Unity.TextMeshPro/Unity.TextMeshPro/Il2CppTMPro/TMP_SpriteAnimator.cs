using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppTMPro
{
	// Token: 0x0200003E RID: 62
	public class TMP_SpriteAnimator : MonoBehaviour
	{
		// Token: 0x060006E2 RID: 1762 RVA: 0x00020750 File Offset: 0x0001E950
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_SpriteAnimator()
		{
			Il2CppClassPointerStore<TMP_SpriteAnimator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_SpriteAnimator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_SpriteAnimator>.NativeClassPtr);
			TMP_SpriteAnimator.NativeFieldInfoPtr_m_animations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator>.NativeClassPtr, "m_animations");
			TMP_SpriteAnimator.NativeFieldInfoPtr_m_TextComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator>.NativeClassPtr, "m_TextComponent");
			TMP_SpriteAnimator.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAnimator>.NativeClassPtr, 100664083);
			TMP_SpriteAnimator.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAnimator>.NativeClassPtr, 100664084);
			TMP_SpriteAnimator.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAnimator>.NativeClassPtr, 100664085);
			TMP_SpriteAnimator.NativeMethodInfoPtr_StopAllAnimations_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAnimator>.NativeClassPtr, 100664086);
			TMP_SpriteAnimator.NativeMethodInfoPtr_DoSpriteAnimation_Public_Void_Int32_TMP_SpriteAsset_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAnimator>.NativeClassPtr, 100664087);
			TMP_SpriteAnimator.NativeMethodInfoPtr_DoSpriteAnimationInternal_Private_IEnumerator_Int32_TMP_SpriteAsset_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAnimator>.NativeClassPtr, 100664088);
			TMP_SpriteAnimator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAnimator>.NativeClassPtr, 100664089);
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00020834 File Offset: 0x0001EA34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459156, XrefRangeEnd = 459159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAnimator.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x00020868 File Offset: 0x0001EA68
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAnimator.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x0002089C File Offset: 0x0001EA9C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAnimator.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x000208D0 File Offset: 0x0001EAD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 459164, RefRangeEnd = 459166, XrefRangeStart = 459159, XrefRangeEnd = 459164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopAllAnimations()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAnimator.NativeMethodInfoPtr_StopAllAnimations_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x00020904 File Offset: 0x0001EB04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459166, XrefRangeEnd = 459175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoSpriteAnimation(int currentCharacter, TMP_SpriteAsset spriteAsset, int start, int end, int framerate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref currentCharacter;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(spriteAsset);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref framerate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAnimator.NativeMethodInfoPtr_DoSpriteAnimation_Public_Void_Int32_TMP_SpriteAsset_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x00020980 File Offset: 0x0001EB80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459175, XrefRangeEnd = 459178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DoSpriteAnimationInternal(int currentCharacter, TMP_SpriteAsset spriteAsset, int start, int end, int framerate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref currentCharacter;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(spriteAsset);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref framerate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAnimator.NativeMethodInfoPtr_DoSpriteAnimationInternal_Private_IEnumerator_Int32_TMP_SpriteAsset_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x00020A08 File Offset: 0x0001EC08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459178, XrefRangeEnd = 459186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_SpriteAnimator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_SpriteAnimator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAnimator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x00005247 File Offset: 0x00003447
		public TMP_SpriteAnimator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x060006EB RID: 1771 RVA: 0x00020A44 File Offset: 0x0001EC44
		// (set) Token: 0x060006EC RID: 1772 RVA: 0x00005250 File Offset: 0x00003450
		public unsafe Dictionary<int, bool> m_animations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator.NativeFieldInfoPtr_m_animations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator.NativeFieldInfoPtr_m_animations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x060006ED RID: 1773 RVA: 0x00020A74 File Offset: 0x0001EC74
		// (set) Token: 0x060006EE RID: 1774 RVA: 0x0000526F File Offset: 0x0000346F
		public unsafe TMP_Text m_TextComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator.NativeFieldInfoPtr_m_TextComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator.NativeFieldInfoPtr_m_TextComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000581 RID: 1409
		private static readonly IntPtr NativeFieldInfoPtr_m_animations;

		// Token: 0x04000582 RID: 1410
		private static readonly IntPtr NativeFieldInfoPtr_m_TextComponent;

		// Token: 0x04000583 RID: 1411
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000584 RID: 1412
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000585 RID: 1413
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000586 RID: 1414
		private static readonly IntPtr NativeMethodInfoPtr_StopAllAnimations_Public_Void_0;

		// Token: 0x04000587 RID: 1415
		private static readonly IntPtr NativeMethodInfoPtr_DoSpriteAnimation_Public_Void_Int32_TMP_SpriteAsset_Int32_Int32_Int32_0;

		// Token: 0x04000588 RID: 1416
		private static readonly IntPtr NativeMethodInfoPtr_DoSpriteAnimationInternal_Private_IEnumerator_Int32_TMP_SpriteAsset_Int32_Int32_Int32_0;

		// Token: 0x04000589 RID: 1417
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000A2 RID: 162
		[ObfuscatedName("TMPro.TMP_SpriteAnimator+<DoSpriteAnimationInternal>d__7")]
		public sealed class _DoSpriteAnimationInternal_d__7 : global::Il2CppSystem.Object
		{
			// Token: 0x06000F9C RID: 3996 RVA: 0x0003DF5C File Offset: 0x0003C15C
			// Note: this type is marked as 'beforefieldinit'.
			static _DoSpriteAnimationInternal_d__7()
			{
				Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_SpriteAnimator>.NativeClassPtr, "<DoSpriteAnimationInternal>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr);
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, "<>1__state");
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, "<>2__current");
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, "<>4__this");
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, "start");
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr_end = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, "end");
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr_spriteAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, "spriteAsset");
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr_currentCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, "currentCharacter");
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr_framerate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, "framerate");
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__currentFrame_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, "<currentFrame>5__2");
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__charInfo_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, "<charInfo>5__3");
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__materialIndex_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, "<materialIndex>5__4");
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__vertexIndex_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, "<vertexIndex>5__5");
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__meshInfo_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, "<meshInfo>5__6");
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__baseSpriteScale_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, "<baseSpriteScale>5__7");
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__elapsedTime_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, "<elapsedTime>5__8");
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__targetTime_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, "<targetTime>5__9");
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, 100664090);
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, 100664091);
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, 100664092);
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, 100664093);
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, 100664094);
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, 100664095);
			}

			// Token: 0x06000F9D RID: 3997 RVA: 0x0003E140 File Offset: 0x0003C340
			[CallerCount(0)]
			public unsafe _DoSpriteAnimationInternal_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000F9E RID: 3998 RVA: 0x0003E188 File Offset: 0x0003C388
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F9F RID: 3999 RVA: 0x0003E1BC File Offset: 0x0003C3BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459117, XrefRangeEnd = 459147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170005BA RID: 1466
			// (get) Token: 0x06000FA0 RID: 4000 RVA: 0x0003E1F8 File Offset: 0x0003C3F8
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000FA1 RID: 4001 RVA: 0x0003E238 File Offset: 0x0003C438
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459147, XrefRangeEnd = 459156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170005BB RID: 1467
			// (get) Token: 0x06000FA2 RID: 4002 RVA: 0x0003E26C File Offset: 0x0003C46C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000FA3 RID: 4003 RVA: 0x000096DB File Offset: 0x000078DB
			public _DoSpriteAnimationInternal_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005AA RID: 1450
			// (get) Token: 0x06000FA4 RID: 4004 RVA: 0x0003E2AC File Offset: 0x0003C4AC
			// (set) Token: 0x06000FA5 RID: 4005 RVA: 0x000096E4 File Offset: 0x000078E4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170005AB RID: 1451
			// (get) Token: 0x06000FA6 RID: 4006 RVA: 0x0003E2D4 File Offset: 0x0003C4D4
			// (set) Token: 0x06000FA7 RID: 4007 RVA: 0x000096FF File Offset: 0x000078FF
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005AC RID: 1452
			// (get) Token: 0x06000FA8 RID: 4008 RVA: 0x0003E304 File Offset: 0x0003C504
			// (set) Token: 0x06000FA9 RID: 4009 RVA: 0x0000971E File Offset: 0x0000791E
			public unsafe TMP_SpriteAnimator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAnimator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005AD RID: 1453
			// (get) Token: 0x06000FAA RID: 4010 RVA: 0x0003E334 File Offset: 0x0003C534
			// (set) Token: 0x06000FAB RID: 4011 RVA: 0x0000973D File Offset: 0x0000793D
			public unsafe int start
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr_start);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr_start)) = value;
				}
			}

			// Token: 0x170005AE RID: 1454
			// (get) Token: 0x06000FAC RID: 4012 RVA: 0x0003E35C File Offset: 0x0003C55C
			// (set) Token: 0x06000FAD RID: 4013 RVA: 0x00009758 File Offset: 0x00007958
			public unsafe int end
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr_end);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr_end)) = value;
				}
			}

			// Token: 0x170005AF RID: 1455
			// (get) Token: 0x06000FAE RID: 4014 RVA: 0x0003E384 File Offset: 0x0003C584
			// (set) Token: 0x06000FAF RID: 4015 RVA: 0x00009773 File Offset: 0x00007973
			public unsafe TMP_SpriteAsset spriteAsset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr_spriteAsset);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr_spriteAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005B0 RID: 1456
			// (get) Token: 0x06000FB0 RID: 4016 RVA: 0x0003E3B4 File Offset: 0x0003C5B4
			// (set) Token: 0x06000FB1 RID: 4017 RVA: 0x00009792 File Offset: 0x00007992
			public unsafe int currentCharacter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr_currentCharacter);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr_currentCharacter)) = value;
				}
			}

			// Token: 0x170005B1 RID: 1457
			// (get) Token: 0x06000FB2 RID: 4018 RVA: 0x0003E3DC File Offset: 0x0003C5DC
			// (set) Token: 0x06000FB3 RID: 4019 RVA: 0x000097AD File Offset: 0x000079AD
			public unsafe int framerate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr_framerate);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr_framerate)) = value;
				}
			}

			// Token: 0x170005B2 RID: 1458
			// (get) Token: 0x06000FB4 RID: 4020 RVA: 0x0003E404 File Offset: 0x0003C604
			// (set) Token: 0x06000FB5 RID: 4021 RVA: 0x000097C8 File Offset: 0x000079C8
			public unsafe int _currentFrame_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__currentFrame_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__currentFrame_5__2)) = value;
				}
			}

			// Token: 0x170005B3 RID: 1459
			// (get) Token: 0x06000FB6 RID: 4022 RVA: 0x0003E42C File Offset: 0x0003C62C
			// (set) Token: 0x06000FB7 RID: 4023 RVA: 0x000097E3 File Offset: 0x000079E3
			public TMP_CharacterInfo _charInfo_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__charInfo_5__3);
					return new TMP_CharacterInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__charInfo_5__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170005B4 RID: 1460
			// (get) Token: 0x06000FB8 RID: 4024 RVA: 0x0003E45C File Offset: 0x0003C65C
			// (set) Token: 0x06000FB9 RID: 4025 RVA: 0x00009811 File Offset: 0x00007A11
			public unsafe int _materialIndex_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__materialIndex_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__materialIndex_5__4)) = value;
				}
			}

			// Token: 0x170005B5 RID: 1461
			// (get) Token: 0x06000FBA RID: 4026 RVA: 0x0003E484 File Offset: 0x0003C684
			// (set) Token: 0x06000FBB RID: 4027 RVA: 0x0000982C File Offset: 0x00007A2C
			public unsafe int _vertexIndex_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__vertexIndex_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__vertexIndex_5__5)) = value;
				}
			}

			// Token: 0x170005B6 RID: 1462
			// (get) Token: 0x06000FBC RID: 4028 RVA: 0x0003E4AC File Offset: 0x0003C6AC
			// (set) Token: 0x06000FBD RID: 4029 RVA: 0x00009847 File Offset: 0x00007A47
			public TMP_MeshInfo _meshInfo_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__meshInfo_5__6);
					return new TMP_MeshInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__meshInfo_5__6), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170005B7 RID: 1463
			// (get) Token: 0x06000FBE RID: 4030 RVA: 0x0003E4DC File Offset: 0x0003C6DC
			// (set) Token: 0x06000FBF RID: 4031 RVA: 0x00009875 File Offset: 0x00007A75
			public unsafe float _baseSpriteScale_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__baseSpriteScale_5__7);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__baseSpriteScale_5__7)) = value;
				}
			}

			// Token: 0x170005B8 RID: 1464
			// (get) Token: 0x06000FC0 RID: 4032 RVA: 0x0003E504 File Offset: 0x0003C704
			// (set) Token: 0x06000FC1 RID: 4033 RVA: 0x00009890 File Offset: 0x00007A90
			public unsafe float _elapsedTime_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__elapsedTime_5__8);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__elapsedTime_5__8)) = value;
				}
			}

			// Token: 0x170005B9 RID: 1465
			// (get) Token: 0x06000FC2 RID: 4034 RVA: 0x0003E52C File Offset: 0x0003C72C
			// (set) Token: 0x06000FC3 RID: 4035 RVA: 0x000098AB File Offset: 0x00007AAB
			public unsafe float _targetTime_5__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__targetTime_5__9);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__targetTime_5__9)) = value;
				}
			}

			// Token: 0x04000C47 RID: 3143
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000C48 RID: 3144
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000C49 RID: 3145
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000C4A RID: 3146
			private static readonly IntPtr NativeFieldInfoPtr_start;

			// Token: 0x04000C4B RID: 3147
			private static readonly IntPtr NativeFieldInfoPtr_end;

			// Token: 0x04000C4C RID: 3148
			private static readonly IntPtr NativeFieldInfoPtr_spriteAsset;

			// Token: 0x04000C4D RID: 3149
			private static readonly IntPtr NativeFieldInfoPtr_currentCharacter;

			// Token: 0x04000C4E RID: 3150
			private static readonly IntPtr NativeFieldInfoPtr_framerate;

			// Token: 0x04000C4F RID: 3151
			private static readonly IntPtr NativeFieldInfoPtr__currentFrame_5__2;

			// Token: 0x04000C50 RID: 3152
			private static readonly IntPtr NativeFieldInfoPtr__charInfo_5__3;

			// Token: 0x04000C51 RID: 3153
			private static readonly IntPtr NativeFieldInfoPtr__materialIndex_5__4;

			// Token: 0x04000C52 RID: 3154
			private static readonly IntPtr NativeFieldInfoPtr__vertexIndex_5__5;

			// Token: 0x04000C53 RID: 3155
			private static readonly IntPtr NativeFieldInfoPtr__meshInfo_5__6;

			// Token: 0x04000C54 RID: 3156
			private static readonly IntPtr NativeFieldInfoPtr__baseSpriteScale_5__7;

			// Token: 0x04000C55 RID: 3157
			private static readonly IntPtr NativeFieldInfoPtr__elapsedTime_5__8;

			// Token: 0x04000C56 RID: 3158
			private static readonly IntPtr NativeFieldInfoPtr__targetTime_5__9;

			// Token: 0x04000C57 RID: 3159
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000C58 RID: 3160
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000C59 RID: 3161
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000C5A RID: 3162
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000C5B RID: 3163
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000C5C RID: 3164
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
