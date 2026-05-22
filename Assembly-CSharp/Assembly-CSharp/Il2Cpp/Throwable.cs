using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020001C4 RID: 452
	public class Throwable : MessageReceiver
	{
		// Token: 0x060031A2 RID: 12706 RVA: 0x000BCBD0 File Offset: 0x000BADD0
		// Note: this type is marked as 'beforefieldinit'.
		static Throwable()
		{
			Il2CppClassPointerStore<Throwable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Throwable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Throwable>.NativeClassPtr);
			Throwable.NativeFieldInfoPtr_groundFric = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Throwable>.NativeClassPtr, "groundFric");
			Throwable.NativeFieldInfoPtr_airFric = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Throwable>.NativeClassPtr, "airFric");
			Throwable.NativeFieldInfoPtr_flySpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Throwable>.NativeClassPtr, "flySpeed");
			Throwable.NativeFieldInfoPtr_prevPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Throwable>.NativeClassPtr, "prevPos");
			Throwable.NativeFieldInfoPtr_prevPrevPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Throwable>.NativeClassPtr, "prevPrevPos");
			Throwable.NativeFieldInfoPtr_prevVel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Throwable>.NativeClassPtr, "prevVel");
			Throwable.NativeFieldInfoPtr_pushDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Throwable>.NativeClassPtr, "pushDist");
			Throwable.NativeFieldInfoPtr_distTraved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Throwable>.NativeClassPtr, "distTraved");
			Throwable.NativeFieldInfoPtr_rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Throwable>.NativeClassPtr, "rb");
			Throwable.NativeFieldInfoPtr_prePushed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Throwable>.NativeClassPtr, "prePushed");
			Throwable.NativeFieldInfoPtr_pushed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Throwable>.NativeClassPtr, "pushed");
			Throwable.NativeFieldInfoPtr_grabbed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Throwable>.NativeClassPtr, "grabbed");
			Throwable.NativeFieldInfoPtr_up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Throwable>.NativeClassPtr, "up");
			Throwable.NativeFieldInfoPtr_breakThrough = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Throwable>.NativeClassPtr, "breakThrough");
			Throwable.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Throwable>.NativeClassPtr, "message");
			Throwable.NativeFieldInfoPtr_blowShit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Throwable>.NativeClassPtr, "blowShit");
			Throwable.NativeFieldInfoPtr_grabLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Throwable>.NativeClassPtr, "grabLayer");
			Throwable.NativeFieldInfoPtr_noPlayerLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Throwable>.NativeClassPtr, "noPlayerLayer");
			Throwable.NativeFieldInfoPtr_flyingLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Throwable>.NativeClassPtr, "flyingLayer");
			Throwable.NativeFieldInfoPtr_falling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Throwable>.NativeClassPtr, "falling");
			Throwable.NativeFieldInfoPtr_floorLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Throwable>.NativeClassPtr, "floorLayer");
			Throwable.NativeFieldInfoPtr_prevLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Throwable>.NativeClassPtr, "prevLayer");
			Throwable.NativeFieldInfoPtr_justHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Throwable>.NativeClassPtr, "justHit");
			Throwable.NativeFieldInfoPtr_grabber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Throwable>.NativeClassPtr, "grabber");
			Throwable.NativeFieldInfoPtr_vel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Throwable>.NativeClassPtr, "vel");
			Throwable.NativeFieldInfoPtr_velSqrMag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Throwable>.NativeClassPtr, "velSqrMag");
			Throwable.NativeMethodInfoPtr_Awake_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Throwable>.NativeClassPtr, 100667169);
			Throwable.NativeMethodInfoPtr_OnFall_Public_Virtual_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Throwable>.NativeClassPtr, 100667170);
			Throwable.NativeMethodInfoPtr_OnEnable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Throwable>.NativeClassPtr, 100667171);
			Throwable.NativeMethodInfoPtr_OnDisable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Throwable>.NativeClassPtr, 100667172);
			Throwable.NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Throwable>.NativeClassPtr, 100667173);
			Throwable.NativeMethodInfoPtr_PushDeal_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Throwable>.NativeClassPtr, 100667174);
			Throwable.NativeMethodInfoPtr_Break_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Throwable>.NativeClassPtr, 100667175);
			Throwable.NativeMethodInfoPtr_PlaySound_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Throwable>.NativeClassPtr, 100667176);
			Throwable.NativeMethodInfoPtr_SetFric_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Throwable>.NativeClassPtr, 100667177);
			Throwable.NativeMethodInfoPtr_SetLayer_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Throwable>.NativeClassPtr, 100667178);
			Throwable.NativeMethodInfoPtr_OnPushed_Public_Virtual_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Throwable>.NativeClassPtr, 100667179);
			Throwable.NativeMethodInfoPtr_OnGrabbed_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Throwable>.NativeClassPtr, 100667180);
			Throwable.NativeMethodInfoPtr_OnPrePushed_Public_Virtual_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Throwable>.NativeClassPtr, 100667181);
			Throwable.NativeMethodInfoPtr_OnShot_Public_Virtual_Void_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Throwable>.NativeClassPtr, 100667182);
			Throwable.NativeMethodInfoPtr_OnBlown_Public_Virtual_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Throwable>.NativeClassPtr, 100667183);
			Throwable.NativeMethodInfoPtr_OnSmashed_Public_Virtual_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Throwable>.NativeClassPtr, 100667184);
			Throwable.NativeMethodInfoPtr_OnSlammed_Public_Virtual_Void_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Throwable>.NativeClassPtr, 100667185);
			Throwable.NativeMethodInfoPtr_OnCollisionEnter2D_Public_Virtual_New_Void_Collision2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Throwable>.NativeClassPtr, 100667186);
			Throwable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Throwable>.NativeClassPtr, 100667187);
		}

		// Token: 0x060031A3 RID: 12707 RVA: 0x000BCF84 File Offset: 0x000BB184
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 85452, RefRangeEnd = 85453, XrefRangeStart = 85430, XrefRangeEnd = 85452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Throwable.NativeMethodInfoPtr_Awake_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031A4 RID: 12708 RVA: 0x000BCFC0 File Offset: 0x000BB1C0
		[CallerCount(0)]
		public unsafe override void OnFall(Vector2 fallVect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fallVect;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Throwable.NativeMethodInfoPtr_OnFall_Public_Virtual_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060031A5 RID: 12709 RVA: 0x000BD00C File Offset: 0x000BB20C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 85461, RefRangeEnd = 85464, XrefRangeStart = 85453, XrefRangeEnd = 85461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Throwable.NativeMethodInfoPtr_OnEnable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031A6 RID: 12710 RVA: 0x000BD048 File Offset: 0x000BB248
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 85471, RefRangeEnd = 85474, XrefRangeStart = 85464, XrefRangeEnd = 85471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Throwable.NativeMethodInfoPtr_OnDisable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031A7 RID: 12711 RVA: 0x000BD084 File Offset: 0x000BB284
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 85494, RefRangeEnd = 85497, XrefRangeStart = 85474, XrefRangeEnd = 85494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MyFixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Throwable.NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031A8 RID: 12712 RVA: 0x000BD0C0 File Offset: 0x000BB2C0
		[CallerCount(0)]
		public unsafe virtual void PushDeal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Throwable.NativeMethodInfoPtr_PushDeal_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031A9 RID: 12713 RVA: 0x000BD0FC File Offset: 0x000BB2FC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 85507, RefRangeEnd = 85510, XrefRangeStart = 85497, XrefRangeEnd = 85507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Break()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Throwable.NativeMethodInfoPtr_Break_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031AA RID: 12714 RVA: 0x000BD138 File Offset: 0x000BB338
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PlaySound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Throwable.NativeMethodInfoPtr_PlaySound_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031AB RID: 12715 RVA: 0x000BD174 File Offset: 0x000BB374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85510, XrefRangeEnd = 85516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetFric()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Throwable.NativeMethodInfoPtr_SetFric_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031AC RID: 12716 RVA: 0x000BD1B0 File Offset: 0x000BB3B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 85518, RefRangeEnd = 85520, XrefRangeStart = 85516, XrefRangeEnd = 85518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetLayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Throwable.NativeMethodInfoPtr_SetLayer_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031AD RID: 12717 RVA: 0x000BD1EC File Offset: 0x000BB3EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85520, XrefRangeEnd = 85525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPushed(Vector2 spd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref spd;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Throwable.NativeMethodInfoPtr_OnPushed_Public_Virtual_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060031AE RID: 12718 RVA: 0x000BD238 File Offset: 0x000BB438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85525, XrefRangeEnd = 85532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGrabbed(bool flarg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flarg;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Throwable.NativeMethodInfoPtr_OnGrabbed_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060031AF RID: 12719 RVA: 0x000BD284 File Offset: 0x000BB484
		[CallerCount(0)]
		public unsafe override void OnPrePushed(Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Throwable.NativeMethodInfoPtr_OnPrePushed_Public_Virtual_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060031B0 RID: 12720 RVA: 0x000BD2D0 File Offset: 0x000BB4D0
		[CallerCount(0)]
		public unsafe override void OnShot(Il2CppStructArray<Vector2> arr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Throwable.NativeMethodInfoPtr_OnShot_Public_Virtual_Void_Il2CppStructArray_1_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060031B1 RID: 12721 RVA: 0x000BD320 File Offset: 0x000BB520
		[CallerCount(0)]
		public unsafe override void OnBlown(Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Throwable.NativeMethodInfoPtr_OnBlown_Public_Virtual_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060031B2 RID: 12722 RVA: 0x000BD36C File Offset: 0x000BB56C
		[CallerCount(0)]
		public unsafe override void OnSmashed(Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Throwable.NativeMethodInfoPtr_OnSmashed_Public_Virtual_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060031B3 RID: 12723 RVA: 0x000BD3B8 File Offset: 0x000BB5B8
		[CallerCount(0)]
		public unsafe override void OnSlammed(Il2CppStructArray<Vector2> pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Throwable.NativeMethodInfoPtr_OnSlammed_Public_Virtual_Void_Il2CppStructArray_1_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060031B4 RID: 12724 RVA: 0x000BD408 File Offset: 0x000BB608
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 85553, RefRangeEnd = 85554, XrefRangeStart = 85532, XrefRangeEnd = 85553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnCollisionEnter2D(Collision2D coll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(coll);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Throwable.NativeMethodInfoPtr_OnCollisionEnter2D_Public_Virtual_New_Void_Collision2D_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060031B5 RID: 12725 RVA: 0x000BD458 File Offset: 0x000BB658
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 85560, RefRangeEnd = 85568, XrefRangeStart = 85554, XrefRangeEnd = 85560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Throwable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Throwable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Throwable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031B6 RID: 12726 RVA: 0x00022099 File Offset: 0x00020299
		public Throwable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170011A6 RID: 4518
		// (get) Token: 0x060031B7 RID: 12727 RVA: 0x000BD494 File Offset: 0x000BB694
		// (set) Token: 0x060031B8 RID: 12728 RVA: 0x000220A2 File Offset: 0x000202A2
		public unsafe float groundFric
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_groundFric);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_groundFric)) = value;
			}
		}

		// Token: 0x170011A7 RID: 4519
		// (get) Token: 0x060031B9 RID: 12729 RVA: 0x000BD4BC File Offset: 0x000BB6BC
		// (set) Token: 0x060031BA RID: 12730 RVA: 0x000220BD File Offset: 0x000202BD
		public unsafe float airFric
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_airFric);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_airFric)) = value;
			}
		}

		// Token: 0x170011A8 RID: 4520
		// (get) Token: 0x060031BB RID: 12731 RVA: 0x000BD4E4 File Offset: 0x000BB6E4
		// (set) Token: 0x060031BC RID: 12732 RVA: 0x000220D8 File Offset: 0x000202D8
		public unsafe float flySpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_flySpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_flySpeed)) = value;
			}
		}

		// Token: 0x170011A9 RID: 4521
		// (get) Token: 0x060031BD RID: 12733 RVA: 0x000BD50C File Offset: 0x000BB70C
		// (set) Token: 0x060031BE RID: 12734 RVA: 0x000220F3 File Offset: 0x000202F3
		public unsafe Vector2 prevPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_prevPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_prevPos)) = value;
			}
		}

		// Token: 0x170011AA RID: 4522
		// (get) Token: 0x060031BF RID: 12735 RVA: 0x000BD534 File Offset: 0x000BB734
		// (set) Token: 0x060031C0 RID: 12736 RVA: 0x0002210E File Offset: 0x0002030E
		public unsafe Vector2 prevPrevPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_prevPrevPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_prevPrevPos)) = value;
			}
		}

		// Token: 0x170011AB RID: 4523
		// (get) Token: 0x060031C1 RID: 12737 RVA: 0x000BD55C File Offset: 0x000BB75C
		// (set) Token: 0x060031C2 RID: 12738 RVA: 0x00022129 File Offset: 0x00020329
		public unsafe Vector2 prevVel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_prevVel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_prevVel)) = value;
			}
		}

		// Token: 0x170011AC RID: 4524
		// (get) Token: 0x060031C3 RID: 12739 RVA: 0x000BD584 File Offset: 0x000BB784
		// (set) Token: 0x060031C4 RID: 12740 RVA: 0x00022144 File Offset: 0x00020344
		public unsafe float pushDist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_pushDist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_pushDist)) = value;
			}
		}

		// Token: 0x170011AD RID: 4525
		// (get) Token: 0x060031C5 RID: 12741 RVA: 0x000BD5AC File Offset: 0x000BB7AC
		// (set) Token: 0x060031C6 RID: 12742 RVA: 0x0002215F File Offset: 0x0002035F
		public unsafe float distTraved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_distTraved);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_distTraved)) = value;
			}
		}

		// Token: 0x170011AE RID: 4526
		// (get) Token: 0x060031C7 RID: 12743 RVA: 0x000BD5D4 File Offset: 0x000BB7D4
		// (set) Token: 0x060031C8 RID: 12744 RVA: 0x0002217A File Offset: 0x0002037A
		public unsafe Rigidbody2D rb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_rb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_rb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011AF RID: 4527
		// (get) Token: 0x060031C9 RID: 12745 RVA: 0x000BD604 File Offset: 0x000BB804
		// (set) Token: 0x060031CA RID: 12746 RVA: 0x00022199 File Offset: 0x00020399
		public unsafe bool prePushed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_prePushed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_prePushed)) = value;
			}
		}

		// Token: 0x170011B0 RID: 4528
		// (get) Token: 0x060031CB RID: 12747 RVA: 0x000BD62C File Offset: 0x000BB82C
		// (set) Token: 0x060031CC RID: 12748 RVA: 0x000221B4 File Offset: 0x000203B4
		public unsafe bool pushed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_pushed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_pushed)) = value;
			}
		}

		// Token: 0x170011B1 RID: 4529
		// (get) Token: 0x060031CD RID: 12749 RVA: 0x000BD654 File Offset: 0x000BB854
		// (set) Token: 0x060031CE RID: 12750 RVA: 0x000221CF File Offset: 0x000203CF
		public unsafe bool grabbed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_grabbed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_grabbed)) = value;
			}
		}

		// Token: 0x170011B2 RID: 4530
		// (get) Token: 0x060031CF RID: 12751 RVA: 0x000BD67C File Offset: 0x000BB87C
		// (set) Token: 0x060031D0 RID: 12752 RVA: 0x000221EA File Offset: 0x000203EA
		public unsafe bool up
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_up);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_up)) = value;
			}
		}

		// Token: 0x170011B3 RID: 4531
		// (get) Token: 0x060031D1 RID: 12753 RVA: 0x000BD6A4 File Offset: 0x000BB8A4
		// (set) Token: 0x060031D2 RID: 12754 RVA: 0x00022205 File Offset: 0x00020405
		public unsafe bool breakThrough
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_breakThrough);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_breakThrough)) = value;
			}
		}

		// Token: 0x170011B4 RID: 4532
		// (get) Token: 0x060031D3 RID: 12755 RVA: 0x000BD6CC File Offset: 0x000BB8CC
		// (set) Token: 0x060031D4 RID: 12756 RVA: 0x00022220 File Offset: 0x00020420
		public unsafe string message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_message);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_message), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170011B5 RID: 4533
		// (get) Token: 0x060031D5 RID: 12757 RVA: 0x000BD6F4 File Offset: 0x000BB8F4
		// (set) Token: 0x060031D6 RID: 12758 RVA: 0x0002223F File Offset: 0x0002043F
		public unsafe bool blowShit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_blowShit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_blowShit)) = value;
			}
		}

		// Token: 0x170011B6 RID: 4534
		// (get) Token: 0x060031D7 RID: 12759 RVA: 0x000BD71C File Offset: 0x000BB91C
		// (set) Token: 0x060031D8 RID: 12760 RVA: 0x0002225A File Offset: 0x0002045A
		public unsafe int grabLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_grabLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_grabLayer)) = value;
			}
		}

		// Token: 0x170011B7 RID: 4535
		// (get) Token: 0x060031D9 RID: 12761 RVA: 0x000BD744 File Offset: 0x000BB944
		// (set) Token: 0x060031DA RID: 12762 RVA: 0x00022275 File Offset: 0x00020475
		public unsafe int noPlayerLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_noPlayerLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_noPlayerLayer)) = value;
			}
		}

		// Token: 0x170011B8 RID: 4536
		// (get) Token: 0x060031DB RID: 12763 RVA: 0x000BD76C File Offset: 0x000BB96C
		// (set) Token: 0x060031DC RID: 12764 RVA: 0x00022290 File Offset: 0x00020490
		public unsafe int flyingLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_flyingLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_flyingLayer)) = value;
			}
		}

		// Token: 0x170011B9 RID: 4537
		// (get) Token: 0x060031DD RID: 12765 RVA: 0x000BD794 File Offset: 0x000BB994
		// (set) Token: 0x060031DE RID: 12766 RVA: 0x000222AB File Offset: 0x000204AB
		public unsafe bool falling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_falling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_falling)) = value;
			}
		}

		// Token: 0x170011BA RID: 4538
		// (get) Token: 0x060031DF RID: 12767 RVA: 0x000BD7BC File Offset: 0x000BB9BC
		// (set) Token: 0x060031E0 RID: 12768 RVA: 0x000222C6 File Offset: 0x000204C6
		public unsafe int floorLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_floorLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_floorLayer)) = value;
			}
		}

		// Token: 0x170011BB RID: 4539
		// (get) Token: 0x060031E1 RID: 12769 RVA: 0x000BD7E4 File Offset: 0x000BB9E4
		// (set) Token: 0x060031E2 RID: 12770 RVA: 0x000222E1 File Offset: 0x000204E1
		public unsafe int prevLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_prevLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_prevLayer)) = value;
			}
		}

		// Token: 0x170011BC RID: 4540
		// (get) Token: 0x060031E3 RID: 12771 RVA: 0x000BD80C File Offset: 0x000BBA0C
		// (set) Token: 0x060031E4 RID: 12772 RVA: 0x000222FC File Offset: 0x000204FC
		public unsafe bool justHit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_justHit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_justHit)) = value;
			}
		}

		// Token: 0x170011BD RID: 4541
		// (get) Token: 0x060031E5 RID: 12773 RVA: 0x000BD834 File Offset: 0x000BBA34
		// (set) Token: 0x060031E6 RID: 12774 RVA: 0x00022317 File Offset: 0x00020517
		public unsafe Grabber grabber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_grabber);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Grabber>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_grabber), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011BE RID: 4542
		// (get) Token: 0x060031E7 RID: 12775 RVA: 0x000BD864 File Offset: 0x000BBA64
		// (set) Token: 0x060031E8 RID: 12776 RVA: 0x00022336 File Offset: 0x00020536
		public unsafe Vector2 vel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_vel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_vel)) = value;
			}
		}

		// Token: 0x170011BF RID: 4543
		// (get) Token: 0x060031E9 RID: 12777 RVA: 0x000BD88C File Offset: 0x000BBA8C
		// (set) Token: 0x060031EA RID: 12778 RVA: 0x00022351 File Offset: 0x00020551
		public unsafe float velSqrMag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_velSqrMag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Throwable.NativeFieldInfoPtr_velSqrMag)) = value;
			}
		}

		// Token: 0x04001D14 RID: 7444
		private static readonly IntPtr NativeFieldInfoPtr_groundFric;

		// Token: 0x04001D15 RID: 7445
		private static readonly IntPtr NativeFieldInfoPtr_airFric;

		// Token: 0x04001D16 RID: 7446
		private static readonly IntPtr NativeFieldInfoPtr_flySpeed;

		// Token: 0x04001D17 RID: 7447
		private static readonly IntPtr NativeFieldInfoPtr_prevPos;

		// Token: 0x04001D18 RID: 7448
		private static readonly IntPtr NativeFieldInfoPtr_prevPrevPos;

		// Token: 0x04001D19 RID: 7449
		private static readonly IntPtr NativeFieldInfoPtr_prevVel;

		// Token: 0x04001D1A RID: 7450
		private static readonly IntPtr NativeFieldInfoPtr_pushDist;

		// Token: 0x04001D1B RID: 7451
		private static readonly IntPtr NativeFieldInfoPtr_distTraved;

		// Token: 0x04001D1C RID: 7452
		private static readonly IntPtr NativeFieldInfoPtr_rb;

		// Token: 0x04001D1D RID: 7453
		private static readonly IntPtr NativeFieldInfoPtr_prePushed;

		// Token: 0x04001D1E RID: 7454
		private static readonly IntPtr NativeFieldInfoPtr_pushed;

		// Token: 0x04001D1F RID: 7455
		private static readonly IntPtr NativeFieldInfoPtr_grabbed;

		// Token: 0x04001D20 RID: 7456
		private static readonly IntPtr NativeFieldInfoPtr_up;

		// Token: 0x04001D21 RID: 7457
		private static readonly IntPtr NativeFieldInfoPtr_breakThrough;

		// Token: 0x04001D22 RID: 7458
		private static readonly IntPtr NativeFieldInfoPtr_message;

		// Token: 0x04001D23 RID: 7459
		private static readonly IntPtr NativeFieldInfoPtr_blowShit;

		// Token: 0x04001D24 RID: 7460
		private static readonly IntPtr NativeFieldInfoPtr_grabLayer;

		// Token: 0x04001D25 RID: 7461
		private static readonly IntPtr NativeFieldInfoPtr_noPlayerLayer;

		// Token: 0x04001D26 RID: 7462
		private static readonly IntPtr NativeFieldInfoPtr_flyingLayer;

		// Token: 0x04001D27 RID: 7463
		private static readonly IntPtr NativeFieldInfoPtr_falling;

		// Token: 0x04001D28 RID: 7464
		private static readonly IntPtr NativeFieldInfoPtr_floorLayer;

		// Token: 0x04001D29 RID: 7465
		private static readonly IntPtr NativeFieldInfoPtr_prevLayer;

		// Token: 0x04001D2A RID: 7466
		private static readonly IntPtr NativeFieldInfoPtr_justHit;

		// Token: 0x04001D2B RID: 7467
		private static readonly IntPtr NativeFieldInfoPtr_grabber;

		// Token: 0x04001D2C RID: 7468
		private static readonly IntPtr NativeFieldInfoPtr_vel;

		// Token: 0x04001D2D RID: 7469
		private static readonly IntPtr NativeFieldInfoPtr_velSqrMag;

		// Token: 0x04001D2E RID: 7470
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_New_Void_0;

		// Token: 0x04001D2F RID: 7471
		private static readonly IntPtr NativeMethodInfoPtr_OnFall_Public_Virtual_Void_Vector2_0;

		// Token: 0x04001D30 RID: 7472
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Virtual_New_Void_0;

		// Token: 0x04001D31 RID: 7473
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Public_Virtual_New_Void_0;

		// Token: 0x04001D32 RID: 7474
		private static readonly IntPtr NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_New_Void_0;

		// Token: 0x04001D33 RID: 7475
		private static readonly IntPtr NativeMethodInfoPtr_PushDeal_Public_Virtual_New_Void_0;

		// Token: 0x04001D34 RID: 7476
		private static readonly IntPtr NativeMethodInfoPtr_Break_Public_Virtual_New_Void_0;

		// Token: 0x04001D35 RID: 7477
		private static readonly IntPtr NativeMethodInfoPtr_PlaySound_Public_Virtual_New_Void_0;

		// Token: 0x04001D36 RID: 7478
		private static readonly IntPtr NativeMethodInfoPtr_SetFric_Public_Virtual_New_Void_0;

		// Token: 0x04001D37 RID: 7479
		private static readonly IntPtr NativeMethodInfoPtr_SetLayer_Public_Virtual_New_Void_0;

		// Token: 0x04001D38 RID: 7480
		private static readonly IntPtr NativeMethodInfoPtr_OnPushed_Public_Virtual_Void_Vector2_0;

		// Token: 0x04001D39 RID: 7481
		private static readonly IntPtr NativeMethodInfoPtr_OnGrabbed_Public_Virtual_Void_Boolean_0;

		// Token: 0x04001D3A RID: 7482
		private static readonly IntPtr NativeMethodInfoPtr_OnPrePushed_Public_Virtual_Void_Vector2_0;

		// Token: 0x04001D3B RID: 7483
		private static readonly IntPtr NativeMethodInfoPtr_OnShot_Public_Virtual_Void_Il2CppStructArray_1_Vector2_0;

		// Token: 0x04001D3C RID: 7484
		private static readonly IntPtr NativeMethodInfoPtr_OnBlown_Public_Virtual_Void_Vector2_0;

		// Token: 0x04001D3D RID: 7485
		private static readonly IntPtr NativeMethodInfoPtr_OnSmashed_Public_Virtual_Void_Vector2_0;

		// Token: 0x04001D3E RID: 7486
		private static readonly IntPtr NativeMethodInfoPtr_OnSlammed_Public_Virtual_Void_Il2CppStructArray_1_Vector2_0;

		// Token: 0x04001D3F RID: 7487
		private static readonly IntPtr NativeMethodInfoPtr_OnCollisionEnter2D_Public_Virtual_New_Void_Collision2D_0;

		// Token: 0x04001D40 RID: 7488
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
