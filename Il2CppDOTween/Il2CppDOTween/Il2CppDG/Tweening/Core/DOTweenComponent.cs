using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppDG.Tweening.Core
{
	// Token: 0x0200004C RID: 76
	public class DOTweenComponent : MonoBehaviour
	{
		// Token: 0x06000488 RID: 1160 RVA: 0x0001B6F0 File Offset: 0x000198F0
		// Note: this type is marked as 'beforefieldinit'.
		static DOTweenComponent()
		{
			Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Core", "DOTweenComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr);
			DOTweenComponent.NativeFieldInfoPtr_inspectorUpdater = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, "inspectorUpdater");
			DOTweenComponent.NativeFieldInfoPtr__unscaledTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, "_unscaledTime");
			DOTweenComponent.NativeFieldInfoPtr__unscaledDeltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, "_unscaledDeltaTime");
			DOTweenComponent.NativeFieldInfoPtr__pausedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, "_pausedTime");
			DOTweenComponent.NativeFieldInfoPtr__duplicateToDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, "_duplicateToDestroy");
			DOTweenComponent.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, 100664189);
			DOTweenComponent.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, 100664190);
			DOTweenComponent.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, 100664191);
			DOTweenComponent.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, 100664192);
			DOTweenComponent.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, 100664193);
			DOTweenComponent.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, 100664194);
			DOTweenComponent.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, 100664195);
			DOTweenComponent.NativeMethodInfoPtr_OnApplicationPause_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, 100664196);
			DOTweenComponent.NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, 100664197);
			DOTweenComponent.NativeMethodInfoPtr_SetCapacity_Public_Virtual_Final_New_IDOTweenInit_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, 100664198);
			DOTweenComponent.NativeMethodInfoPtr_WaitForCompletion_Internal_IEnumerator_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, 100664199);
			DOTweenComponent.NativeMethodInfoPtr_WaitForRewind_Internal_IEnumerator_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, 100664200);
			DOTweenComponent.NativeMethodInfoPtr_WaitForKill_Internal_IEnumerator_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, 100664201);
			DOTweenComponent.NativeMethodInfoPtr_WaitForElapsedLoops_Internal_IEnumerator_Tween_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, 100664202);
			DOTweenComponent.NativeMethodInfoPtr_WaitForPosition_Internal_IEnumerator_Tween_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, 100664203);
			DOTweenComponent.NativeMethodInfoPtr_WaitForStart_Internal_IEnumerator_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, 100664204);
			DOTweenComponent.NativeMethodInfoPtr_Create_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, 100664205);
			DOTweenComponent.NativeMethodInfoPtr_DestroyInstance_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, 100664206);
			DOTweenComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, 100664207);
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x0001B900 File Offset: 0x00019B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124343, XrefRangeEnd = 124383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x0001B934 File Offset: 0x00019B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124383, XrefRangeEnd = 124408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x0001B968 File Offset: 0x00019B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124408, XrefRangeEnd = 124473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x0001B99C File Offset: 0x00019B9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124473, XrefRangeEnd = 124492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x0001B9D0 File Offset: 0x00019BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124492, XrefRangeEnd = 124519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x0001BA04 File Offset: 0x00019C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124519, XrefRangeEnd = 124537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x0001BA38 File Offset: 0x00019C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124537, XrefRangeEnd = 124602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x0001BA6C File Offset: 0x00019C6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124602, XrefRangeEnd = 124604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnApplicationPause(bool pauseStatus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pauseStatus;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent.NativeMethodInfoPtr_OnApplicationPause_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x0001BAAC File Offset: 0x00019CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124604, XrefRangeEnd = 124608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnApplicationQuit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent.NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x0001BAE0 File Offset: 0x00019CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124608, XrefRangeEnd = 124612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDOTweenInit SetCapacity(int tweenersCapacity, int sequencesCapacity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tweenersCapacity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sequencesCapacity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent.NativeMethodInfoPtr_SetCapacity_Public_Virtual_Final_New_IDOTweenInit_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDOTweenInit>(intPtr3) : null;
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x0001BB3C File Offset: 0x00019D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124612, XrefRangeEnd = 124615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator WaitForCompletion(Tween t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent.NativeMethodInfoPtr_WaitForCompletion_Internal_IEnumerator_Tween_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x0001BB8C File Offset: 0x00019D8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124615, XrefRangeEnd = 124618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator WaitForRewind(Tween t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent.NativeMethodInfoPtr_WaitForRewind_Internal_IEnumerator_Tween_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x0001BBDC File Offset: 0x00019DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124618, XrefRangeEnd = 124621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator WaitForKill(Tween t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent.NativeMethodInfoPtr_WaitForKill_Internal_IEnumerator_Tween_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x0001BC2C File Offset: 0x00019E2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124621, XrefRangeEnd = 124624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator WaitForElapsedLoops(Tween t, int elapsedLoops)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedLoops;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent.NativeMethodInfoPtr_WaitForElapsedLoops_Internal_IEnumerator_Tween_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x0001BC8C File Offset: 0x00019E8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124624, XrefRangeEnd = 124627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator WaitForPosition(Tween t, float position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent.NativeMethodInfoPtr_WaitForPosition_Internal_IEnumerator_Tween_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x0001BCEC File Offset: 0x00019EEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124627, XrefRangeEnd = 124630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator WaitForStart(Tween t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent.NativeMethodInfoPtr_WaitForStart_Internal_IEnumerator_Tween_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x0001BD3C File Offset: 0x00019F3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124662, RefRangeEnd = 124663, XrefRangeStart = 124630, XrefRangeEnd = 124662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent.NativeMethodInfoPtr_Create_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x0001BD64 File Offset: 0x00019F64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124695, RefRangeEnd = 124696, XrefRangeStart = 124663, XrefRangeEnd = 124695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DestroyInstance()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent.NativeMethodInfoPtr_DestroyInstance_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x0001BD8C File Offset: 0x00019F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DOTweenComponent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x000036B2 File Offset: 0x000018B2
		public DOTweenComponent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x0001BDC8 File Offset: 0x00019FC8
		// (set) Token: 0x0600049E RID: 1182 RVA: 0x000036BB File Offset: 0x000018BB
		public unsafe int inspectorUpdater
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent.NativeFieldInfoPtr_inspectorUpdater);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent.NativeFieldInfoPtr_inspectorUpdater)) = value;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x0001BDF0 File Offset: 0x00019FF0
		// (set) Token: 0x060004A0 RID: 1184 RVA: 0x000036D6 File Offset: 0x000018D6
		public unsafe float _unscaledTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent.NativeFieldInfoPtr__unscaledTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent.NativeFieldInfoPtr__unscaledTime)) = value;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x0001BE18 File Offset: 0x0001A018
		// (set) Token: 0x060004A2 RID: 1186 RVA: 0x000036F1 File Offset: 0x000018F1
		public unsafe float _unscaledDeltaTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent.NativeFieldInfoPtr__unscaledDeltaTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent.NativeFieldInfoPtr__unscaledDeltaTime)) = value;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060004A3 RID: 1187 RVA: 0x0001BE40 File Offset: 0x0001A040
		// (set) Token: 0x060004A4 RID: 1188 RVA: 0x0000370C File Offset: 0x0000190C
		public unsafe float _pausedTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent.NativeFieldInfoPtr__pausedTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent.NativeFieldInfoPtr__pausedTime)) = value;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060004A5 RID: 1189 RVA: 0x0001BE68 File Offset: 0x0001A068
		// (set) Token: 0x060004A6 RID: 1190 RVA: 0x00003727 File Offset: 0x00001927
		public unsafe bool _duplicateToDestroy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent.NativeFieldInfoPtr__duplicateToDestroy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent.NativeFieldInfoPtr__duplicateToDestroy)) = value;
			}
		}

		// Token: 0x040003BB RID: 955
		private static readonly IntPtr NativeFieldInfoPtr_inspectorUpdater;

		// Token: 0x040003BC RID: 956
		private static readonly IntPtr NativeFieldInfoPtr__unscaledTime;

		// Token: 0x040003BD RID: 957
		private static readonly IntPtr NativeFieldInfoPtr__unscaledDeltaTime;

		// Token: 0x040003BE RID: 958
		private static readonly IntPtr NativeFieldInfoPtr__pausedTime;

		// Token: 0x040003BF RID: 959
		private static readonly IntPtr NativeFieldInfoPtr__duplicateToDestroy;

		// Token: 0x040003C0 RID: 960
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040003C1 RID: 961
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040003C2 RID: 962
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040003C3 RID: 963
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040003C4 RID: 964
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x040003C5 RID: 965
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x040003C6 RID: 966
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040003C7 RID: 967
		private static readonly IntPtr NativeMethodInfoPtr_OnApplicationPause_Public_Void_Boolean_0;

		// Token: 0x040003C8 RID: 968
		private static readonly IntPtr NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0;

		// Token: 0x040003C9 RID: 969
		private static readonly IntPtr NativeMethodInfoPtr_SetCapacity_Public_Virtual_Final_New_IDOTweenInit_Int32_Int32_0;

		// Token: 0x040003CA RID: 970
		private static readonly IntPtr NativeMethodInfoPtr_WaitForCompletion_Internal_IEnumerator_Tween_0;

		// Token: 0x040003CB RID: 971
		private static readonly IntPtr NativeMethodInfoPtr_WaitForRewind_Internal_IEnumerator_Tween_0;

		// Token: 0x040003CC RID: 972
		private static readonly IntPtr NativeMethodInfoPtr_WaitForKill_Internal_IEnumerator_Tween_0;

		// Token: 0x040003CD RID: 973
		private static readonly IntPtr NativeMethodInfoPtr_WaitForElapsedLoops_Internal_IEnumerator_Tween_Int32_0;

		// Token: 0x040003CE RID: 974
		private static readonly IntPtr NativeMethodInfoPtr_WaitForPosition_Internal_IEnumerator_Tween_Single_0;

		// Token: 0x040003CF RID: 975
		private static readonly IntPtr NativeMethodInfoPtr_WaitForStart_Internal_IEnumerator_Tween_0;

		// Token: 0x040003D0 RID: 976
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_Void_0;

		// Token: 0x040003D1 RID: 977
		private static readonly IntPtr NativeMethodInfoPtr_DestroyInstance_Internal_Static_Void_0;

		// Token: 0x040003D2 RID: 978
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000E6 RID: 230
		[ObfuscatedName("DG.Tweening.Core.DOTweenComponent+<WaitForCompletion>d__15")]
		public sealed class _WaitForCompletion_d__15 : global::Il2CppSystem.Object
		{
			// Token: 0x06000872 RID: 2162 RVA: 0x000286D8 File Offset: 0x000268D8
			// Note: this type is marked as 'beforefieldinit'.
			static _WaitForCompletion_d__15()
			{
				Il2CppClassPointerStore<DOTweenComponent._WaitForCompletion_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, "<WaitForCompletion>d__15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenComponent._WaitForCompletion_d__15>.NativeClassPtr);
				DOTweenComponent._WaitForCompletion_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenComponent._WaitForCompletion_d__15>.NativeClassPtr, "<>1__state");
				DOTweenComponent._WaitForCompletion_d__15.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenComponent._WaitForCompletion_d__15>.NativeClassPtr, "<>2__current");
				DOTweenComponent._WaitForCompletion_d__15.NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenComponent._WaitForCompletion_d__15>.NativeClassPtr, "t");
				DOTweenComponent._WaitForCompletion_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForCompletion_d__15>.NativeClassPtr, 100664208);
				DOTweenComponent._WaitForCompletion_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForCompletion_d__15>.NativeClassPtr, 100664209);
				DOTweenComponent._WaitForCompletion_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForCompletion_d__15>.NativeClassPtr, 100664210);
				DOTweenComponent._WaitForCompletion_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForCompletion_d__15>.NativeClassPtr, 100664211);
				DOTweenComponent._WaitForCompletion_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForCompletion_d__15>.NativeClassPtr, 100664212);
				DOTweenComponent._WaitForCompletion_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForCompletion_d__15>.NativeClassPtr, 100664213);
			}

			// Token: 0x06000873 RID: 2163 RVA: 0x000287B8 File Offset: 0x000269B8
			[CallerCount(0)]
			public unsafe _WaitForCompletion_d__15(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenComponent._WaitForCompletion_d__15>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForCompletion_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000874 RID: 2164 RVA: 0x00028800 File Offset: 0x00026A00
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForCompletion_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000875 RID: 2165 RVA: 0x00028834 File Offset: 0x00026A34
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForCompletion_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000195 RID: 405
			// (get) Token: 0x06000876 RID: 2166 RVA: 0x00028870 File Offset: 0x00026A70
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForCompletion_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000877 RID: 2167 RVA: 0x000288B0 File Offset: 0x00026AB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124313, XrefRangeEnd = 124318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForCompletion_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000196 RID: 406
			// (get) Token: 0x06000878 RID: 2168 RVA: 0x000288E4 File Offset: 0x00026AE4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForCompletion_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000879 RID: 2169 RVA: 0x00004E89 File Offset: 0x00003089
			public _WaitForCompletion_d__15(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000192 RID: 402
			// (get) Token: 0x0600087A RID: 2170 RVA: 0x00028924 File Offset: 0x00026B24
			// (set) Token: 0x0600087B RID: 2171 RVA: 0x00004E92 File Offset: 0x00003092
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForCompletion_d__15.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForCompletion_d__15.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000193 RID: 403
			// (get) Token: 0x0600087C RID: 2172 RVA: 0x0002894C File Offset: 0x00026B4C
			// (set) Token: 0x0600087D RID: 2173 RVA: 0x00004EAD File Offset: 0x000030AD
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForCompletion_d__15.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForCompletion_d__15.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000194 RID: 404
			// (get) Token: 0x0600087E RID: 2174 RVA: 0x0002897C File Offset: 0x00026B7C
			// (set) Token: 0x0600087F RID: 2175 RVA: 0x00004ECC File Offset: 0x000030CC
			public unsafe Tween t
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForCompletion_d__15.NativeFieldInfoPtr_t);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tween>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForCompletion_d__15.NativeFieldInfoPtr_t), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000647 RID: 1607
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000648 RID: 1608
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000649 RID: 1609
			private static readonly IntPtr NativeFieldInfoPtr_t;

			// Token: 0x0400064A RID: 1610
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400064B RID: 1611
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400064C RID: 1612
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400064D RID: 1613
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400064E RID: 1614
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400064F RID: 1615
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020000E7 RID: 231
		[ObfuscatedName("DG.Tweening.Core.DOTweenComponent+<WaitForRewind>d__16")]
		public sealed class _WaitForRewind_d__16 : global::Il2CppSystem.Object
		{
			// Token: 0x06000880 RID: 2176 RVA: 0x000289AC File Offset: 0x00026BAC
			// Note: this type is marked as 'beforefieldinit'.
			static _WaitForRewind_d__16()
			{
				Il2CppClassPointerStore<DOTweenComponent._WaitForRewind_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, "<WaitForRewind>d__16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenComponent._WaitForRewind_d__16>.NativeClassPtr);
				DOTweenComponent._WaitForRewind_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenComponent._WaitForRewind_d__16>.NativeClassPtr, "<>1__state");
				DOTweenComponent._WaitForRewind_d__16.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenComponent._WaitForRewind_d__16>.NativeClassPtr, "<>2__current");
				DOTweenComponent._WaitForRewind_d__16.NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenComponent._WaitForRewind_d__16>.NativeClassPtr, "t");
				DOTweenComponent._WaitForRewind_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForRewind_d__16>.NativeClassPtr, 100664214);
				DOTweenComponent._WaitForRewind_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForRewind_d__16>.NativeClassPtr, 100664215);
				DOTweenComponent._WaitForRewind_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForRewind_d__16>.NativeClassPtr, 100664216);
				DOTweenComponent._WaitForRewind_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForRewind_d__16>.NativeClassPtr, 100664217);
				DOTweenComponent._WaitForRewind_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForRewind_d__16>.NativeClassPtr, 100664218);
				DOTweenComponent._WaitForRewind_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForRewind_d__16>.NativeClassPtr, 100664219);
			}

			// Token: 0x06000881 RID: 2177 RVA: 0x00028A8C File Offset: 0x00026C8C
			[CallerCount(0)]
			public unsafe _WaitForRewind_d__16(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenComponent._WaitForRewind_d__16>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForRewind_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000882 RID: 2178 RVA: 0x00028AD4 File Offset: 0x00026CD4
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForRewind_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000883 RID: 2179 RVA: 0x00028B08 File Offset: 0x00026D08
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForRewind_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700019A RID: 410
			// (get) Token: 0x06000884 RID: 2180 RVA: 0x00028B44 File Offset: 0x00026D44
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForRewind_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000885 RID: 2181 RVA: 0x00028B84 File Offset: 0x00026D84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124318, XrefRangeEnd = 124323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForRewind_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700019B RID: 411
			// (get) Token: 0x06000886 RID: 2182 RVA: 0x00028BB8 File Offset: 0x00026DB8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForRewind_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000887 RID: 2183 RVA: 0x00004EEB File Offset: 0x000030EB
			public _WaitForRewind_d__16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000197 RID: 407
			// (get) Token: 0x06000888 RID: 2184 RVA: 0x00028BF8 File Offset: 0x00026DF8
			// (set) Token: 0x06000889 RID: 2185 RVA: 0x00004EF4 File Offset: 0x000030F4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForRewind_d__16.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForRewind_d__16.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000198 RID: 408
			// (get) Token: 0x0600088A RID: 2186 RVA: 0x00028C20 File Offset: 0x00026E20
			// (set) Token: 0x0600088B RID: 2187 RVA: 0x00004F0F File Offset: 0x0000310F
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForRewind_d__16.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForRewind_d__16.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000199 RID: 409
			// (get) Token: 0x0600088C RID: 2188 RVA: 0x00028C50 File Offset: 0x00026E50
			// (set) Token: 0x0600088D RID: 2189 RVA: 0x00004F2E File Offset: 0x0000312E
			public unsafe Tween t
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForRewind_d__16.NativeFieldInfoPtr_t);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tween>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForRewind_d__16.NativeFieldInfoPtr_t), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000650 RID: 1616
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000651 RID: 1617
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000652 RID: 1618
			private static readonly IntPtr NativeFieldInfoPtr_t;

			// Token: 0x04000653 RID: 1619
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000654 RID: 1620
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000655 RID: 1621
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000656 RID: 1622
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000657 RID: 1623
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000658 RID: 1624
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020000E8 RID: 232
		[ObfuscatedName("DG.Tweening.Core.DOTweenComponent+<WaitForKill>d__17")]
		public sealed class _WaitForKill_d__17 : global::Il2CppSystem.Object
		{
			// Token: 0x0600088E RID: 2190 RVA: 0x00028C80 File Offset: 0x00026E80
			// Note: this type is marked as 'beforefieldinit'.
			static _WaitForKill_d__17()
			{
				Il2CppClassPointerStore<DOTweenComponent._WaitForKill_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, "<WaitForKill>d__17");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenComponent._WaitForKill_d__17>.NativeClassPtr);
				DOTweenComponent._WaitForKill_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenComponent._WaitForKill_d__17>.NativeClassPtr, "<>1__state");
				DOTweenComponent._WaitForKill_d__17.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenComponent._WaitForKill_d__17>.NativeClassPtr, "<>2__current");
				DOTweenComponent._WaitForKill_d__17.NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenComponent._WaitForKill_d__17>.NativeClassPtr, "t");
				DOTweenComponent._WaitForKill_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForKill_d__17>.NativeClassPtr, 100664220);
				DOTweenComponent._WaitForKill_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForKill_d__17>.NativeClassPtr, 100664221);
				DOTweenComponent._WaitForKill_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForKill_d__17>.NativeClassPtr, 100664222);
				DOTweenComponent._WaitForKill_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForKill_d__17>.NativeClassPtr, 100664223);
				DOTweenComponent._WaitForKill_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForKill_d__17>.NativeClassPtr, 100664224);
				DOTweenComponent._WaitForKill_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForKill_d__17>.NativeClassPtr, 100664225);
			}

			// Token: 0x0600088F RID: 2191 RVA: 0x00028D60 File Offset: 0x00026F60
			[CallerCount(0)]
			public unsafe _WaitForKill_d__17(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenComponent._WaitForKill_d__17>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForKill_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000890 RID: 2192 RVA: 0x00028DA8 File Offset: 0x00026FA8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForKill_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000891 RID: 2193 RVA: 0x00028DDC File Offset: 0x00026FDC
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForKill_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700019F RID: 415
			// (get) Token: 0x06000892 RID: 2194 RVA: 0x00028E18 File Offset: 0x00027018
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForKill_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000893 RID: 2195 RVA: 0x00028E58 File Offset: 0x00027058
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124323, XrefRangeEnd = 124328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForKill_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170001A0 RID: 416
			// (get) Token: 0x06000894 RID: 2196 RVA: 0x00028E8C File Offset: 0x0002708C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForKill_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000895 RID: 2197 RVA: 0x00004F4D File Offset: 0x0000314D
			public _WaitForKill_d__17(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700019C RID: 412
			// (get) Token: 0x06000896 RID: 2198 RVA: 0x00028ECC File Offset: 0x000270CC
			// (set) Token: 0x06000897 RID: 2199 RVA: 0x00004F56 File Offset: 0x00003156
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForKill_d__17.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForKill_d__17.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700019D RID: 413
			// (get) Token: 0x06000898 RID: 2200 RVA: 0x00028EF4 File Offset: 0x000270F4
			// (set) Token: 0x06000899 RID: 2201 RVA: 0x00004F71 File Offset: 0x00003171
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForKill_d__17.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForKill_d__17.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700019E RID: 414
			// (get) Token: 0x0600089A RID: 2202 RVA: 0x00028F24 File Offset: 0x00027124
			// (set) Token: 0x0600089B RID: 2203 RVA: 0x00004F90 File Offset: 0x00003190
			public unsafe Tween t
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForKill_d__17.NativeFieldInfoPtr_t);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tween>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForKill_d__17.NativeFieldInfoPtr_t), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000659 RID: 1625
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400065A RID: 1626
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400065B RID: 1627
			private static readonly IntPtr NativeFieldInfoPtr_t;

			// Token: 0x0400065C RID: 1628
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400065D RID: 1629
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400065E RID: 1630
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400065F RID: 1631
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000660 RID: 1632
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000661 RID: 1633
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020000E9 RID: 233
		[ObfuscatedName("DG.Tweening.Core.DOTweenComponent+<WaitForElapsedLoops>d__18")]
		public sealed class _WaitForElapsedLoops_d__18 : global::Il2CppSystem.Object
		{
			// Token: 0x0600089C RID: 2204 RVA: 0x00028F54 File Offset: 0x00027154
			// Note: this type is marked as 'beforefieldinit'.
			static _WaitForElapsedLoops_d__18()
			{
				Il2CppClassPointerStore<DOTweenComponent._WaitForElapsedLoops_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, "<WaitForElapsedLoops>d__18");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenComponent._WaitForElapsedLoops_d__18>.NativeClassPtr);
				DOTweenComponent._WaitForElapsedLoops_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenComponent._WaitForElapsedLoops_d__18>.NativeClassPtr, "<>1__state");
				DOTweenComponent._WaitForElapsedLoops_d__18.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenComponent._WaitForElapsedLoops_d__18>.NativeClassPtr, "<>2__current");
				DOTweenComponent._WaitForElapsedLoops_d__18.NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenComponent._WaitForElapsedLoops_d__18>.NativeClassPtr, "t");
				DOTweenComponent._WaitForElapsedLoops_d__18.NativeFieldInfoPtr_elapsedLoops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenComponent._WaitForElapsedLoops_d__18>.NativeClassPtr, "elapsedLoops");
				DOTweenComponent._WaitForElapsedLoops_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForElapsedLoops_d__18>.NativeClassPtr, 100664226);
				DOTweenComponent._WaitForElapsedLoops_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForElapsedLoops_d__18>.NativeClassPtr, 100664227);
				DOTweenComponent._WaitForElapsedLoops_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForElapsedLoops_d__18>.NativeClassPtr, 100664228);
				DOTweenComponent._WaitForElapsedLoops_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForElapsedLoops_d__18>.NativeClassPtr, 100664229);
				DOTweenComponent._WaitForElapsedLoops_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForElapsedLoops_d__18>.NativeClassPtr, 100664230);
				DOTweenComponent._WaitForElapsedLoops_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForElapsedLoops_d__18>.NativeClassPtr, 100664231);
			}

			// Token: 0x0600089D RID: 2205 RVA: 0x00029048 File Offset: 0x00027248
			[CallerCount(0)]
			public unsafe _WaitForElapsedLoops_d__18(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenComponent._WaitForElapsedLoops_d__18>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForElapsedLoops_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600089E RID: 2206 RVA: 0x00029090 File Offset: 0x00027290
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForElapsedLoops_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600089F RID: 2207 RVA: 0x000290C4 File Offset: 0x000272C4
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForElapsedLoops_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170001A5 RID: 421
			// (get) Token: 0x060008A0 RID: 2208 RVA: 0x00029100 File Offset: 0x00027300
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForElapsedLoops_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060008A1 RID: 2209 RVA: 0x00029140 File Offset: 0x00027340
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124328, XrefRangeEnd = 124333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForElapsedLoops_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170001A6 RID: 422
			// (get) Token: 0x060008A2 RID: 2210 RVA: 0x00029174 File Offset: 0x00027374
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForElapsedLoops_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060008A3 RID: 2211 RVA: 0x00004FAF File Offset: 0x000031AF
			public _WaitForElapsedLoops_d__18(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001A1 RID: 417
			// (get) Token: 0x060008A4 RID: 2212 RVA: 0x000291B4 File Offset: 0x000273B4
			// (set) Token: 0x060008A5 RID: 2213 RVA: 0x00004FB8 File Offset: 0x000031B8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForElapsedLoops_d__18.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForElapsedLoops_d__18.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170001A2 RID: 418
			// (get) Token: 0x060008A6 RID: 2214 RVA: 0x000291DC File Offset: 0x000273DC
			// (set) Token: 0x060008A7 RID: 2215 RVA: 0x00004FD3 File Offset: 0x000031D3
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForElapsedLoops_d__18.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForElapsedLoops_d__18.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001A3 RID: 419
			// (get) Token: 0x060008A8 RID: 2216 RVA: 0x0002920C File Offset: 0x0002740C
			// (set) Token: 0x060008A9 RID: 2217 RVA: 0x00004FF2 File Offset: 0x000031F2
			public unsafe Tween t
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForElapsedLoops_d__18.NativeFieldInfoPtr_t);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tween>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForElapsedLoops_d__18.NativeFieldInfoPtr_t), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001A4 RID: 420
			// (get) Token: 0x060008AA RID: 2218 RVA: 0x0002923C File Offset: 0x0002743C
			// (set) Token: 0x060008AB RID: 2219 RVA: 0x00005011 File Offset: 0x00003211
			public unsafe int elapsedLoops
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForElapsedLoops_d__18.NativeFieldInfoPtr_elapsedLoops);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForElapsedLoops_d__18.NativeFieldInfoPtr_elapsedLoops)) = value;
				}
			}

			// Token: 0x04000662 RID: 1634
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000663 RID: 1635
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000664 RID: 1636
			private static readonly IntPtr NativeFieldInfoPtr_t;

			// Token: 0x04000665 RID: 1637
			private static readonly IntPtr NativeFieldInfoPtr_elapsedLoops;

			// Token: 0x04000666 RID: 1638
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000667 RID: 1639
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000668 RID: 1640
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000669 RID: 1641
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400066A RID: 1642
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400066B RID: 1643
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020000EA RID: 234
		[ObfuscatedName("DG.Tweening.Core.DOTweenComponent+<WaitForPosition>d__19")]
		public sealed class _WaitForPosition_d__19 : global::Il2CppSystem.Object
		{
			// Token: 0x060008AC RID: 2220 RVA: 0x00029264 File Offset: 0x00027464
			// Note: this type is marked as 'beforefieldinit'.
			static _WaitForPosition_d__19()
			{
				Il2CppClassPointerStore<DOTweenComponent._WaitForPosition_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, "<WaitForPosition>d__19");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenComponent._WaitForPosition_d__19>.NativeClassPtr);
				DOTweenComponent._WaitForPosition_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenComponent._WaitForPosition_d__19>.NativeClassPtr, "<>1__state");
				DOTweenComponent._WaitForPosition_d__19.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenComponent._WaitForPosition_d__19>.NativeClassPtr, "<>2__current");
				DOTweenComponent._WaitForPosition_d__19.NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenComponent._WaitForPosition_d__19>.NativeClassPtr, "t");
				DOTweenComponent._WaitForPosition_d__19.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenComponent._WaitForPosition_d__19>.NativeClassPtr, "position");
				DOTweenComponent._WaitForPosition_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForPosition_d__19>.NativeClassPtr, 100664232);
				DOTweenComponent._WaitForPosition_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForPosition_d__19>.NativeClassPtr, 100664233);
				DOTweenComponent._WaitForPosition_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForPosition_d__19>.NativeClassPtr, 100664234);
				DOTweenComponent._WaitForPosition_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForPosition_d__19>.NativeClassPtr, 100664235);
				DOTweenComponent._WaitForPosition_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForPosition_d__19>.NativeClassPtr, 100664236);
				DOTweenComponent._WaitForPosition_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForPosition_d__19>.NativeClassPtr, 100664237);
			}

			// Token: 0x060008AD RID: 2221 RVA: 0x00029358 File Offset: 0x00027558
			[CallerCount(0)]
			public unsafe _WaitForPosition_d__19(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenComponent._WaitForPosition_d__19>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForPosition_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060008AE RID: 2222 RVA: 0x000293A0 File Offset: 0x000275A0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForPosition_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060008AF RID: 2223 RVA: 0x000293D4 File Offset: 0x000275D4
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForPosition_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170001AB RID: 427
			// (get) Token: 0x060008B0 RID: 2224 RVA: 0x00029410 File Offset: 0x00027610
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForPosition_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060008B1 RID: 2225 RVA: 0x00029450 File Offset: 0x00027650
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124333, XrefRangeEnd = 124338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForPosition_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170001AC RID: 428
			// (get) Token: 0x060008B2 RID: 2226 RVA: 0x00029484 File Offset: 0x00027684
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForPosition_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060008B3 RID: 2227 RVA: 0x0000502C File Offset: 0x0000322C
			public _WaitForPosition_d__19(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001A7 RID: 423
			// (get) Token: 0x060008B4 RID: 2228 RVA: 0x000294C4 File Offset: 0x000276C4
			// (set) Token: 0x060008B5 RID: 2229 RVA: 0x00005035 File Offset: 0x00003235
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForPosition_d__19.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForPosition_d__19.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170001A8 RID: 424
			// (get) Token: 0x060008B6 RID: 2230 RVA: 0x000294EC File Offset: 0x000276EC
			// (set) Token: 0x060008B7 RID: 2231 RVA: 0x00005050 File Offset: 0x00003250
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForPosition_d__19.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForPosition_d__19.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001A9 RID: 425
			// (get) Token: 0x060008B8 RID: 2232 RVA: 0x0002951C File Offset: 0x0002771C
			// (set) Token: 0x060008B9 RID: 2233 RVA: 0x0000506F File Offset: 0x0000326F
			public unsafe Tween t
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForPosition_d__19.NativeFieldInfoPtr_t);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tween>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForPosition_d__19.NativeFieldInfoPtr_t), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001AA RID: 426
			// (get) Token: 0x060008BA RID: 2234 RVA: 0x0002954C File Offset: 0x0002774C
			// (set) Token: 0x060008BB RID: 2235 RVA: 0x0000508E File Offset: 0x0000328E
			public unsafe float position
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForPosition_d__19.NativeFieldInfoPtr_position);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForPosition_d__19.NativeFieldInfoPtr_position)) = value;
				}
			}

			// Token: 0x0400066C RID: 1644
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400066D RID: 1645
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400066E RID: 1646
			private static readonly IntPtr NativeFieldInfoPtr_t;

			// Token: 0x0400066F RID: 1647
			private static readonly IntPtr NativeFieldInfoPtr_position;

			// Token: 0x04000670 RID: 1648
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000671 RID: 1649
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000672 RID: 1650
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000673 RID: 1651
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000674 RID: 1652
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000675 RID: 1653
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020000EB RID: 235
		[ObfuscatedName("DG.Tweening.Core.DOTweenComponent+<WaitForStart>d__20")]
		public sealed class _WaitForStart_d__20 : global::Il2CppSystem.Object
		{
			// Token: 0x060008BC RID: 2236 RVA: 0x00029574 File Offset: 0x00027774
			// Note: this type is marked as 'beforefieldinit'.
			static _WaitForStart_d__20()
			{
				Il2CppClassPointerStore<DOTweenComponent._WaitForStart_d__20>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, "<WaitForStart>d__20");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenComponent._WaitForStart_d__20>.NativeClassPtr);
				DOTweenComponent._WaitForStart_d__20.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenComponent._WaitForStart_d__20>.NativeClassPtr, "<>1__state");
				DOTweenComponent._WaitForStart_d__20.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenComponent._WaitForStart_d__20>.NativeClassPtr, "<>2__current");
				DOTweenComponent._WaitForStart_d__20.NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenComponent._WaitForStart_d__20>.NativeClassPtr, "t");
				DOTweenComponent._WaitForStart_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForStart_d__20>.NativeClassPtr, 100664238);
				DOTweenComponent._WaitForStart_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForStart_d__20>.NativeClassPtr, 100664239);
				DOTweenComponent._WaitForStart_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForStart_d__20>.NativeClassPtr, 100664240);
				DOTweenComponent._WaitForStart_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForStart_d__20>.NativeClassPtr, 100664241);
				DOTweenComponent._WaitForStart_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForStart_d__20>.NativeClassPtr, 100664242);
				DOTweenComponent._WaitForStart_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForStart_d__20>.NativeClassPtr, 100664243);
			}

			// Token: 0x060008BD RID: 2237 RVA: 0x00029654 File Offset: 0x00027854
			[CallerCount(0)]
			public unsafe _WaitForStart_d__20(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenComponent._WaitForStart_d__20>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForStart_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060008BE RID: 2238 RVA: 0x0002969C File Offset: 0x0002789C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForStart_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060008BF RID: 2239 RVA: 0x000296D0 File Offset: 0x000278D0
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForStart_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170001B0 RID: 432
			// (get) Token: 0x060008C0 RID: 2240 RVA: 0x0002970C File Offset: 0x0002790C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForStart_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060008C1 RID: 2241 RVA: 0x0002974C File Offset: 0x0002794C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124338, XrefRangeEnd = 124343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForStart_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170001B1 RID: 433
			// (get) Token: 0x060008C2 RID: 2242 RVA: 0x00029780 File Offset: 0x00027980
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForStart_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060008C3 RID: 2243 RVA: 0x000050A9 File Offset: 0x000032A9
			public _WaitForStart_d__20(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001AD RID: 429
			// (get) Token: 0x060008C4 RID: 2244 RVA: 0x000297C0 File Offset: 0x000279C0
			// (set) Token: 0x060008C5 RID: 2245 RVA: 0x000050B2 File Offset: 0x000032B2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForStart_d__20.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForStart_d__20.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170001AE RID: 430
			// (get) Token: 0x060008C6 RID: 2246 RVA: 0x000297E8 File Offset: 0x000279E8
			// (set) Token: 0x060008C7 RID: 2247 RVA: 0x000050CD File Offset: 0x000032CD
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForStart_d__20.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForStart_d__20.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001AF RID: 431
			// (get) Token: 0x060008C8 RID: 2248 RVA: 0x00029818 File Offset: 0x00027A18
			// (set) Token: 0x060008C9 RID: 2249 RVA: 0x000050EC File Offset: 0x000032EC
			public unsafe Tween t
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForStart_d__20.NativeFieldInfoPtr_t);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tween>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForStart_d__20.NativeFieldInfoPtr_t), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000676 RID: 1654
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000677 RID: 1655
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000678 RID: 1656
			private static readonly IntPtr NativeFieldInfoPtr_t;

			// Token: 0x04000679 RID: 1657
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400067A RID: 1658
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400067B RID: 1659
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400067C RID: 1660
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400067D RID: 1661
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400067E RID: 1662
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
