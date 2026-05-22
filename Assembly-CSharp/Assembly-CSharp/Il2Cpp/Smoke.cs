using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000192 RID: 402
	public class Smoke : MonoBehaviour
	{
		// Token: 0x06002F39 RID: 12089 RVA: 0x000B6900 File Offset: 0x000B4B00
		// Note: this type is marked as 'beforefieldinit'.
		static Smoke()
		{
			Il2CppClassPointerStore<Smoke>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Smoke");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Smoke>.NativeClassPtr);
			Smoke.NativeFieldInfoPtr_part = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Smoke>.NativeClassPtr, "part");
			Smoke.NativeFieldInfoPtr_streaks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Smoke>.NativeClassPtr, "streaks");
			Smoke.NativeFieldInfoPtr_smart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Smoke>.NativeClassPtr, "smart");
			Smoke.NativeFieldInfoPtr_partNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Smoke>.NativeClassPtr, "partNum");
			Smoke.NativeFieldInfoPtr_partArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Smoke>.NativeClassPtr, "partArr");
			Smoke.NativeFieldInfoPtr_partSpriteArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Smoke>.NativeClassPtr, "partSpriteArr");
			Smoke.NativeFieldInfoPtr_partRad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Smoke>.NativeClassPtr, "partRad");
			Smoke.NativeFieldInfoPtr_arrNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Smoke>.NativeClassPtr, "arrNum");
			Smoke.NativeFieldInfoPtr_mesher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Smoke>.NativeClassPtr, "mesher");
			Smoke.NativeFieldInfoPtr_verts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Smoke>.NativeClassPtr, "verts");
			Smoke.NativeFieldInfoPtr_sidePts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Smoke>.NativeClassPtr, "sidePts");
			Smoke.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Smoke>.NativeClassPtr, "player");
			Smoke.NativeFieldInfoPtr_spriteRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Smoke>.NativeClassPtr, "spriteRend");
			Smoke.NativeFieldInfoPtr_meshRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Smoke>.NativeClassPtr, "meshRend");
			Smoke.NativeFieldInfoPtr_shadowLayerer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Smoke>.NativeClassPtr, "shadowLayerer");
			Smoke.NativeFieldInfoPtr_circCol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Smoke>.NativeClassPtr, "circCol");
			Smoke.NativeFieldInfoPtr_angi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Smoke>.NativeClassPtr, "angi");
			Smoke.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Smoke>.NativeClassPtr, 100667004);
			Smoke.NativeMethodInfoPtr_FixedUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Smoke>.NativeClassPtr, 100667005);
			Smoke.NativeMethodInfoPtr_LateUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Smoke>.NativeClassPtr, 100667006);
			Smoke.NativeMethodInfoPtr_SpawnPart_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Smoke>.NativeClassPtr, 100667007);
			Smoke.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Smoke>.NativeClassPtr, 100667008);
		}

		// Token: 0x06002F3A RID: 12090 RVA: 0x000B6AE8 File Offset: 0x000B4CE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83268, XrefRangeEnd = 83289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Smoke.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F3B RID: 12091 RVA: 0x000B6B1C File Offset: 0x000B4D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83289, XrefRangeEnd = 83294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Smoke.NativeMethodInfoPtr_FixedUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F3C RID: 12092 RVA: 0x000B6B50 File Offset: 0x000B4D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83294, XrefRangeEnd = 83313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Smoke.NativeMethodInfoPtr_LateUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F3D RID: 12093 RVA: 0x000B6B84 File Offset: 0x000B4D84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 83384, RefRangeEnd = 83385, XrefRangeStart = 83313, XrefRangeEnd = 83384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpawnPart(float ang)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ang;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Smoke.NativeMethodInfoPtr_SpawnPart_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F3E RID: 12094 RVA: 0x000B6BC4 File Offset: 0x000B4DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Smoke()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Smoke>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Smoke.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F3F RID: 12095 RVA: 0x000208CA File Offset: 0x0001EACA
		public Smoke(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170010EA RID: 4330
		// (get) Token: 0x06002F40 RID: 12096 RVA: 0x000B6C00 File Offset: 0x000B4E00
		// (set) Token: 0x06002F41 RID: 12097 RVA: 0x000208D3 File Offset: 0x0001EAD3
		public unsafe ParticleSystem part
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Smoke.NativeFieldInfoPtr_part);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Smoke.NativeFieldInfoPtr_part), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010EB RID: 4331
		// (get) Token: 0x06002F42 RID: 12098 RVA: 0x000B6C30 File Offset: 0x000B4E30
		// (set) Token: 0x06002F43 RID: 12099 RVA: 0x000208F2 File Offset: 0x0001EAF2
		public unsafe Il2CppReferenceArray<ParticleSystem> streaks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Smoke.NativeFieldInfoPtr_streaks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParticleSystem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Smoke.NativeFieldInfoPtr_streaks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010EC RID: 4332
		// (get) Token: 0x06002F44 RID: 12100 RVA: 0x000B6C60 File Offset: 0x000B4E60
		// (set) Token: 0x06002F45 RID: 12101 RVA: 0x00020911 File Offset: 0x0001EB11
		public unsafe GameObject smart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Smoke.NativeFieldInfoPtr_smart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Smoke.NativeFieldInfoPtr_smart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010ED RID: 4333
		// (get) Token: 0x06002F46 RID: 12102 RVA: 0x000B6C90 File Offset: 0x000B4E90
		// (set) Token: 0x06002F47 RID: 12103 RVA: 0x00020930 File Offset: 0x0001EB30
		public unsafe int partNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Smoke.NativeFieldInfoPtr_partNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Smoke.NativeFieldInfoPtr_partNum)) = value;
			}
		}

		// Token: 0x170010EE RID: 4334
		// (get) Token: 0x06002F48 RID: 12104 RVA: 0x000B6CB8 File Offset: 0x000B4EB8
		// (set) Token: 0x06002F49 RID: 12105 RVA: 0x0002094B File Offset: 0x0001EB4B
		public unsafe Il2CppReferenceArray<GameObject> partArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Smoke.NativeFieldInfoPtr_partArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Smoke.NativeFieldInfoPtr_partArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010EF RID: 4335
		// (get) Token: 0x06002F4A RID: 12106 RVA: 0x000B6CE8 File Offset: 0x000B4EE8
		// (set) Token: 0x06002F4B RID: 12107 RVA: 0x0002096A File Offset: 0x0001EB6A
		public unsafe Il2CppReferenceArray<SpriteRenderer> partSpriteArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Smoke.NativeFieldInfoPtr_partSpriteArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SpriteRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Smoke.NativeFieldInfoPtr_partSpriteArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010F0 RID: 4336
		// (get) Token: 0x06002F4C RID: 12108 RVA: 0x000B6D18 File Offset: 0x000B4F18
		// (set) Token: 0x06002F4D RID: 12109 RVA: 0x00020989 File Offset: 0x0001EB89
		public unsafe float partRad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Smoke.NativeFieldInfoPtr_partRad);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Smoke.NativeFieldInfoPtr_partRad)) = value;
			}
		}

		// Token: 0x170010F1 RID: 4337
		// (get) Token: 0x06002F4E RID: 12110 RVA: 0x000B6D40 File Offset: 0x000B4F40
		// (set) Token: 0x06002F4F RID: 12111 RVA: 0x000209A4 File Offset: 0x0001EBA4
		public unsafe int arrNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Smoke.NativeFieldInfoPtr_arrNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Smoke.NativeFieldInfoPtr_arrNum)) = value;
			}
		}

		// Token: 0x170010F2 RID: 4338
		// (get) Token: 0x06002F50 RID: 12112 RVA: 0x000B6D68 File Offset: 0x000B4F68
		// (set) Token: 0x06002F51 RID: 12113 RVA: 0x000209BF File Offset: 0x0001EBBF
		public unsafe MeshFilter mesher
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Smoke.NativeFieldInfoPtr_mesher);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Smoke.NativeFieldInfoPtr_mesher), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010F3 RID: 4339
		// (get) Token: 0x06002F52 RID: 12114 RVA: 0x000B6D98 File Offset: 0x000B4F98
		// (set) Token: 0x06002F53 RID: 12115 RVA: 0x000209DE File Offset: 0x0001EBDE
		public unsafe Il2CppStructArray<Vector3> verts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Smoke.NativeFieldInfoPtr_verts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Smoke.NativeFieldInfoPtr_verts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010F4 RID: 4340
		// (get) Token: 0x06002F54 RID: 12116 RVA: 0x000B6DC8 File Offset: 0x000B4FC8
		// (set) Token: 0x06002F55 RID: 12117 RVA: 0x000209FD File Offset: 0x0001EBFD
		public unsafe Il2CppStructArray<Vector2> sidePts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Smoke.NativeFieldInfoPtr_sidePts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Smoke.NativeFieldInfoPtr_sidePts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010F5 RID: 4341
		// (get) Token: 0x06002F56 RID: 12118 RVA: 0x000B6DF8 File Offset: 0x000B4FF8
		// (set) Token: 0x06002F57 RID: 12119 RVA: 0x00020A1C File Offset: 0x0001EC1C
		public unsafe GameObject player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Smoke.NativeFieldInfoPtr_player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Smoke.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010F6 RID: 4342
		// (get) Token: 0x06002F58 RID: 12120 RVA: 0x000B6E28 File Offset: 0x000B5028
		// (set) Token: 0x06002F59 RID: 12121 RVA: 0x00020A3B File Offset: 0x0001EC3B
		public unsafe SpriteRenderer spriteRend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Smoke.NativeFieldInfoPtr_spriteRend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Smoke.NativeFieldInfoPtr_spriteRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010F7 RID: 4343
		// (get) Token: 0x06002F5A RID: 12122 RVA: 0x000B6E58 File Offset: 0x000B5058
		// (set) Token: 0x06002F5B RID: 12123 RVA: 0x00020A5A File Offset: 0x0001EC5A
		public unsafe MeshRenderer meshRend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Smoke.NativeFieldInfoPtr_meshRend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Smoke.NativeFieldInfoPtr_meshRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010F8 RID: 4344
		// (get) Token: 0x06002F5C RID: 12124 RVA: 0x000B6E88 File Offset: 0x000B5088
		// (set) Token: 0x06002F5D RID: 12125 RVA: 0x00020A79 File Offset: 0x0001EC79
		public unsafe ShadowLayerer shadowLayerer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Smoke.NativeFieldInfoPtr_shadowLayerer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShadowLayerer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Smoke.NativeFieldInfoPtr_shadowLayerer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010F9 RID: 4345
		// (get) Token: 0x06002F5E RID: 12126 RVA: 0x000B6EB8 File Offset: 0x000B50B8
		// (set) Token: 0x06002F5F RID: 12127 RVA: 0x00020A98 File Offset: 0x0001EC98
		public unsafe CircleCollider2D circCol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Smoke.NativeFieldInfoPtr_circCol);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CircleCollider2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Smoke.NativeFieldInfoPtr_circCol), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010FA RID: 4346
		// (get) Token: 0x06002F60 RID: 12128 RVA: 0x000B6EE8 File Offset: 0x000B50E8
		// (set) Token: 0x06002F61 RID: 12129 RVA: 0x00020AB7 File Offset: 0x0001ECB7
		public unsafe int angi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Smoke.NativeFieldInfoPtr_angi);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Smoke.NativeFieldInfoPtr_angi)) = value;
			}
		}

		// Token: 0x04001BCB RID: 7115
		private static readonly IntPtr NativeFieldInfoPtr_part;

		// Token: 0x04001BCC RID: 7116
		private static readonly IntPtr NativeFieldInfoPtr_streaks;

		// Token: 0x04001BCD RID: 7117
		private static readonly IntPtr NativeFieldInfoPtr_smart;

		// Token: 0x04001BCE RID: 7118
		private static readonly IntPtr NativeFieldInfoPtr_partNum;

		// Token: 0x04001BCF RID: 7119
		private static readonly IntPtr NativeFieldInfoPtr_partArr;

		// Token: 0x04001BD0 RID: 7120
		private static readonly IntPtr NativeFieldInfoPtr_partSpriteArr;

		// Token: 0x04001BD1 RID: 7121
		private static readonly IntPtr NativeFieldInfoPtr_partRad;

		// Token: 0x04001BD2 RID: 7122
		private static readonly IntPtr NativeFieldInfoPtr_arrNum;

		// Token: 0x04001BD3 RID: 7123
		private static readonly IntPtr NativeFieldInfoPtr_mesher;

		// Token: 0x04001BD4 RID: 7124
		private static readonly IntPtr NativeFieldInfoPtr_verts;

		// Token: 0x04001BD5 RID: 7125
		private static readonly IntPtr NativeFieldInfoPtr_sidePts;

		// Token: 0x04001BD6 RID: 7126
		private static readonly IntPtr NativeFieldInfoPtr_player;

		// Token: 0x04001BD7 RID: 7127
		private static readonly IntPtr NativeFieldInfoPtr_spriteRend;

		// Token: 0x04001BD8 RID: 7128
		private static readonly IntPtr NativeFieldInfoPtr_meshRend;

		// Token: 0x04001BD9 RID: 7129
		private static readonly IntPtr NativeFieldInfoPtr_shadowLayerer;

		// Token: 0x04001BDA RID: 7130
		private static readonly IntPtr NativeFieldInfoPtr_circCol;

		// Token: 0x04001BDB RID: 7131
		private static readonly IntPtr NativeFieldInfoPtr_angi;

		// Token: 0x04001BDC RID: 7132
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04001BDD RID: 7133
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Public_Void_0;

		// Token: 0x04001BDE RID: 7134
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Public_Void_0;

		// Token: 0x04001BDF RID: 7135
		private static readonly IntPtr NativeMethodInfoPtr_SpawnPart_Public_Void_Single_0;

		// Token: 0x04001BE0 RID: 7136
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
