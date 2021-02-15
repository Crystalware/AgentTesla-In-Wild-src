using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ADODB;
using College_Management_System.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace College_Management_System
{
	// Token: 0x02000016 RID: 22
	[DesignerGenerated]
	public class Form6 : Form
	{
		// Token: 0x060001BA RID: 442 RVA: 0x00018B34 File Offset: 0x00016D34
		public Form6()
		{
			for (;;)
			{
				IL_A2:
				int num = 21;
				int num2 = -10;
				for (;;)
				{
					num2 ^= 69;
					for (;;)
					{
						IL_4E:
						int num3 = Form7.mqgfoefwabbyeu(24);
						int num4 = 23;
						for (;;)
						{
							switch (num4 ^ 69)
							{
							case 79:
								switch (num3 + 78)
								{
								case 0:
									switch (num2 + 80)
									{
									case 0:
										goto IL_A2;
									case 1:
										switch (num)
										{
										case 81:
											this.rs = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00000535-0000-0010-8000-00AA006D2EA4")));
											num = 18;
											goto IL_11;
										case 82:
											this.con = (Connection)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00000514-0000-0010-8000-00AA006D2EA4")));
											num = 22;
											goto IL_11;
										case 83:
										{
											RuntimeMethodHandle runtimeMethodHandle = methodof(Form6.get_txtUsername()).MethodHandle;
											num = 20;
											goto IL_11;
										}
										case 84:
											num = 17;
											goto IL_11;
										case 85:
											this.sbdifomqugmukl();
											num = 19;
											goto IL_11;
										case 86:
											return;
										}
										goto Block_2;
									case 2:
										goto IL_D6;
									case 3:
										break;
									default:
										num3 = -8;
										goto IL_22;
									}
									IL_11:
									num ^= 71;
									break;
								case 1:
								{
									RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form6.get_Label3()).MethodHandle;
									num3 = -1;
									goto IL_22;
								}
								case 2:
									break;
								case 3:
									goto IL_9D;
								default:
									num4 = 21;
									continue;
								}
								num2 = Form12.wsyoqrrjsoniul(58);
								num3 = -7;
								goto IL_22;
							case 80:
								goto IL_4E;
							case 81:
							{
								RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form6.set_txtUsername(TextBox)).MethodHandle;
								num4 = 20;
								continue;
							}
							case 82:
								goto IL_22;
							}
							IL_3B:
							num4 = 10;
							continue;
							IL_22:
							num3 ^= 76;
							goto IL_3B;
						}
					}
					IL_9D:
					continue;
					Block_2:
					num2 = -11;
					continue;
					IL_D6:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form6.set_txtPassword(TextBox)).MethodHandle;
					num2 = Form7.mqgfoefwabbyeu(32);
				}
			}
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00018CF0 File Offset: 0x00016EF0
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				bool flag = disposing && this.components != null;
				if (flag)
				{
					for (;;)
					{
						IL_117:
						int num = 7;
						int num2 = -10;
						for (;;)
						{
							num2 ^= 78;
							for (;;)
							{
								IL_AB:
								int num3 = Form6.sbdifomqugmuko(57);
								int num4 = 20;
								for (;;)
								{
									switch (num4 ^ 69)
									{
									case 78:
									{
										RuntimeMethodHandle runtimeMethodHandle = methodof(Form6.sbdifomqugmukm(object, EventArgs)).MethodHandle;
										num4 = 11;
										continue;
									}
									case 79:
										switch (num3 + 70)
										{
										case 0:
											switch (num2 + 75)
											{
											case 0:
												goto IL_104;
											case 1:
												goto IL_117;
											case 2:
												switch (num)
												{
												case 71:
													num = 5;
													goto IL_3E;
												case 72:
													this.components.Dispose();
													num = 8;
													goto IL_3E;
												case 73:
												{
													RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form6.Dispose(bool)).MethodHandle;
													num = 6;
													goto IL_3E;
												}
												case 74:
													goto IL_197;
												}
												goto Block_6;
											case 3:
												break;
											default:
												num3 = -22;
												goto IL_4F;
											}
											IL_3E:
											num ^= 79;
											break;
										case 1:
											break;
										case 2:
										{
											RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form6.sbdifomqugmukm(object, EventArgs)).MethodHandle;
											num3 = Form8.nxfpeikhibypgs(75);
											goto IL_4F;
										}
										case 3:
											goto IL_FF;
										default:
											num4 = 21;
											continue;
										}
										num2 = Form12.wsyoqrrjsoniul(51);
										num3 = -20;
										break;
									case 80:
										goto IL_AB;
									case 81:
										break;
									default:
										IL_7A:
										num4 = 10;
										continue;
									}
									IL_4F:
									num3 ^= 81;
									goto IL_7A;
								}
							}
							IL_FF:
							continue;
							IL_104:
							RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form6.sbdifomqugmukn(object, EventArgs)).MethodHandle;
							num2 = Form2.uwpnsrqhswlmjh(34);
							continue;
							Block_6:
							num2 = -8;
						}
					}
					IL_197:;
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00018EC0 File Offset: 0x000170C0
		[DebuggerStepThrough]
		private void sbdifomqugmukl()
		{
			for (;;)
			{
				int num = Form12.wsyoqrrjsoniul(40);
				for (;;)
				{
					num ^= 70;
					switch (num + 74)
					{
					case 0:
						this.Label3.TabIndex = 23;
						this.Label3.Text = "Password:";
						this.Label2.AutoSize = true;
						num = -115;
						continue;
					case 1:
						this.cmdLogin.Size = new Size(92, 31);
						this.cmdLogin.TabIndex = 26;
						this.cmdLogin.Text = "LOGIN";
						num = -4;
						continue;
					case 2:
						this.txtUsername = new TextBox();
						this.Label3 = new Label();
						this.Label2 = new Label();
						num = -6;
						continue;
					case 3:
						this.Text = "Form6";
						base.ResumeLayout(false);
						base.PerformLayout();
						num = -120;
						continue;
					case 4:
						this.cmdLogin.UseVisualStyleBackColor = false;
						this.txtPassword.Location = new Point(171, 164);
						this.txtPassword.Name = "txtPassword";
						num = -116;
						continue;
					case 5:
						this.cmdCancel.Location = new Point(240, 241);
						this.cmdCancel.Name = "cmdCancel";
						this.cmdCancel.Size = new Size(92, 31);
						num = -117;
						continue;
					case 6:
						this.Label1 = new Label();
						base.SuspendLayout();
						this.cmdCancel.BackColor = Color.FromArgb(128, 128, 255);
						num = -3;
						continue;
					case 7:
						this.txtUsername.Location = new Point(171, 114);
						this.txtUsername.Name = "txtUsername";
						this.txtUsername.Size = new Size(161, 23);
						num = -118;
						continue;
					case 8:
					{
						ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form6));
						this.cmdCancel = new Button();
						this.cmdLogin = new Button();
						this.txtPassword = new TextBox();
						num = -2;
						continue;
					}
					case 9:
						this.Label2.Size = new Size(77, 17);
						this.Label2.TabIndex = 22;
						this.Label2.Text = "Username:";
						num = -122;
						continue;
					case 10:
						for (;;)
						{
							int num2 = Form2.uwpnsrqhswlmjh(45);
							for (;;)
							{
								num2 ^= 80;
								switch (num2 + 74)
								{
								case 0:
									this.Label1.Location = new Point(95, 49);
									num2 = -24;
									continue;
								case 1:
									num2 = -26;
									continue;
								case 2:
									num = -127;
									num2 = -19;
									continue;
								case 3:
									this.Label1.AutoSize = true;
									num2 = -20;
									continue;
								case 4:
								{
									RuntimeMethodHandle runtimeMethodHandle = methodof(Form6.get_Label1()).MethodHandle;
									num2 = -22;
									continue;
								}
								case 5:
									this.Label1.BackColor = Color.FromArgb(128, 128, 255);
									num2 = -25;
									continue;
								case 6:
									num2 = Form6.sbdifomqugmuko(57);
									continue;
								case 7:
									goto IL_318;
								}
								break;
							}
						}
						IL_318:
						continue;
					case 11:
					{
						RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form6.get_Label2()).MethodHandle;
						num = -121;
						continue;
					}
					case 12:
					{
						ComponentResourceManager componentResourceManager;
						this.BackgroundImage = (Image)componentResourceManager.GetObject("$this.BackgroundImage");
						base.ClientSize = new Size(403, 321);
						base.Controls.Add(this.cmdCancel);
						num = -126;
						continue;
					}
					case 13:
						for (;;)
						{
							int num3 = 20;
							for (;;)
							{
								switch (num3 ^ 70)
								{
								case 77:
									num3 = 22;
									continue;
								case 78:
									this.cmdLogin.Name = "cmdLogin";
									num3 = 9;
									continue;
								case 79:
									num = -15;
									num3 = 18;
									continue;
								case 80:
									this.cmdLogin.Location = new Point(73, 241);
									num3 = 21;
									continue;
								case 81:
								{
									RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form6.get_txtUsername()).MethodHandle;
									num3 = 23;
									continue;
								}
								case 82:
									this.cmdLogin.BackColor = Color.FromArgb(128, 128, 255);
									num3 = 11;
									continue;
								case 83:
									num3 = 8;
									continue;
								case 84:
									goto IL_42F;
								}
								break;
							}
						}
						IL_42F:
						continue;
					case 14:
						base.Controls.Add(this.cmdLogin);
						base.Controls.Add(this.txtPassword);
						base.Controls.Add(this.txtUsername);
						num = -125;
						continue;
					case 15:
						base.Controls.Add(this.Label3);
						base.Controls.Add(this.Label2);
						base.Controls.Add(this.Label1);
						num = -128;
						continue;
					case 16:
						for (;;)
						{
							int num4 = 6;
							for (;;)
							{
								switch (num4 ^ 77)
								{
								case 71:
									base.Margin = new Padding(4, 4, 4, 4);
									num4 = 7;
									continue;
								case 72:
									num = -1;
									num4 = 3;
									continue;
								case 73:
									base.Name = "Form6";
									num4 = 5;
									continue;
								case 74:
									num4 = 4;
									continue;
								case 75:
									this.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
									num4 = 1;
									continue;
								case 76:
									num4 = 10;
									continue;
								case 77:
								{
									RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form6.set_cmdCancel(Button)).MethodHandle;
									num4 = 0;
									continue;
								}
								case 78:
									goto IL_544;
								}
								break;
							}
						}
						IL_544:
						continue;
					case 17:
						this.Label1.Name = "Label1";
						this.Label1.Size = new Size(237, 17);
						this.Label1.TabIndex = 21;
						num = -113;
						continue;
					case 18:
						this.Label3.Location = new Point(73, 164);
						this.Label3.Name = "Label3";
						this.Label3.Size = new Size(73, 17);
						num = -16;
						continue;
					case 19:
						this.Label1.Text = "Welcome to the Student Login Menu";
						base.AutoScaleDimensions = new SizeF(8f, 16f);
						base.AutoScaleMode = AutoScaleMode.Font;
						num = -124;
						continue;
					case 20:
						this.txtPassword.PasswordChar = '*';
						this.txtPassword.Size = new Size(161, 23);
						this.txtPassword.TabIndex = 25;
						num = -5;
						continue;
					case 21:
						this.Label2.BackColor = Color.FromArgb(128, 128, 255);
						this.Label2.Location = new Point(70, 114);
						this.Label2.Name = "Label2";
						num = -7;
						continue;
					case 22:
						this.txtUsername.TabIndex = 24;
						this.Label3.AutoSize = true;
						this.Label3.BackColor = Color.FromArgb(128, 128, 255);
						num = -114;
						continue;
					case 23:
						this.cmdCancel.TabIndex = 27;
						this.cmdCancel.Text = "CANCEL";
						this.cmdCancel.UseVisualStyleBackColor = false;
						num = Form10.pdqangwdsoatqb(66);
						continue;
					case 24:
						return;
					}
					break;
				}
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060001BD RID: 445 RVA: 0x00019669 File Offset: 0x00017869
		// (set) Token: 0x060001BE RID: 446 RVA: 0x00019678 File Offset: 0x00017878
		internal virtual Button cmdCancel
		{
			[CompilerGenerated]
			get
			{
				return this._cmdCancel;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.sbdifomqugmukn);
				Button cmdCancel = this._cmdCancel;
				if (cmdCancel != null)
				{
					cmdCancel.Click -= value2;
				}
				this._cmdCancel = value;
				cmdCancel = this._cmdCancel;
				if (cmdCancel != null)
				{
					cmdCancel.Click += value2;
				}
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060001BF RID: 447 RVA: 0x000196E3 File Offset: 0x000178E3
		// (set) Token: 0x060001C0 RID: 448 RVA: 0x000196F4 File Offset: 0x000178F4
		internal virtual Button cmdLogin
		{
			[CompilerGenerated]
			get
			{
				return this._cmdLogin;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.sbdifomqugmukm);
				Button cmdLogin = this._cmdLogin;
				if (cmdLogin != null)
				{
					cmdLogin.Click -= value2;
				}
				this._cmdLogin = value;
				cmdLogin = this._cmdLogin;
				if (cmdLogin != null)
				{
					cmdLogin.Click += value2;
				}
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x0001975F File Offset: 0x0001795F
		// (set) Token: 0x060001C2 RID: 450 RVA: 0x0001976D File Offset: 0x0001796D
		internal virtual TextBox txtPassword { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x0001977A File Offset: 0x0001797A
		// (set) Token: 0x060001C4 RID: 452 RVA: 0x00019788 File Offset: 0x00017988
		internal virtual TextBox txtUsername { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x00019795 File Offset: 0x00017995
		// (set) Token: 0x060001C6 RID: 454 RVA: 0x000197A3 File Offset: 0x000179A3
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x000197B0 File Offset: 0x000179B0
		// (set) Token: 0x060001C8 RID: 456 RVA: 0x000197BE File Offset: 0x000179BE
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x000197CB File Offset: 0x000179CB
		// (set) Token: 0x060001CA RID: 458 RVA: 0x000197D9 File Offset: 0x000179D9
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x060001CB RID: 459 RVA: 0x000197E8 File Offset: 0x000179E8
		private void sbdifomqugmukm(object cs, EventArgs ct)
		{
			string str;
			for (;;)
			{
				int num = 1;
				for (;;)
				{
					switch (num ^ 79)
					{
					case 74:
					{
						RuntimeMethodHandle runtimeMethodHandle = methodof(Form6.get_cmdLogin()).MethodHandle;
						num = 5;
						continue;
					}
					case 75:
						this.rs.Open("Select * from StudentsProfile where AdmNo = '" + this.txtUsername.Text + "'", this.con, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
						num = 0;
						continue;
					case 76:
						this.con.Open("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\\Users\\Joey\\Documents\\College.mdb; Persist Security Info = False", "", "", -1);
						num = 2;
						continue;
					case 77:
						num = 4;
						continue;
					case 78:
						str = "";
						num = 3;
						continue;
					case 79:
						goto IL_9A;
					}
					break;
				}
			}
			IL_9A:
			try
			{
				str = Conversions.ToString(this.rs.Fields["FirstName"].Value);
			}
			catch (Exception ex)
			{
			}
			bool eof = this.rs.EOF;
			if (eof)
			{
				this.con.Close();
				for (;;)
				{
					int num2 = 2;
					for (;;)
					{
						switch (num2 ^ 80)
						{
						case 80:
							num2 = 7;
							continue;
						case 81:
							Interaction.MsgBox("Username Not Found. Please Try Again.", MsgBoxStyle.Exclamation, "Login Error");
							num2 = 5;
							continue;
						case 82:
							num2 = 1;
							continue;
						case 83:
							this.txtPassword.Text = "";
							num2 = 0;
							continue;
						case 84:
						{
							RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form6.get_Label2()).MethodHandle;
							num2 = 4;
							continue;
						}
						case 85:
							this.txtUsername.Text = "";
							num2 = 8;
							continue;
						case 86:
							num2 = 9;
							continue;
						case 87:
							this.txtUsername.Focus();
							num2 = 6;
							continue;
						case 88:
							num2 = 3;
							continue;
						case 89:
							goto IL_1B8;
						}
						break;
					}
				}
				IL_1B8:;
			}
			else
			{
				bool flag = Operators.ConditionalCompareObjectEqual(this.txtPassword.Text, this.rs.Fields["Password"].Value, false);
				if (flag)
				{
					this.con.Close();
					for (;;)
					{
						int num3 = Form7.mqgfoefwabbyeu(25);
						for (;;)
						{
							num3 ^= 76;
							switch (num3 + 78)
							{
							case 0:
								Interaction.MsgBox("Welcome, " + str + "!", MsgBoxStyle.Information, "Access Granted");
								num3 = -10;
								continue;
							case 1:
								num3 = -2;
								continue;
							case 2:
								num3 = -11;
								continue;
							case 3:
								yupufqwjlhlkfh.whvgmsxtmdbkxx.hcphoarosyelxf.txtAdmNo.Enabled = false;
								num3 = -8;
								continue;
							case 4:
								num3 = -5;
								continue;
							case 5:
								yupufqwjlhlkfh.whvgmsxtmdbkxx.hcphoarosyelxf.Show();
								num3 = -12;
								continue;
							case 6:
								num3 = -7;
								continue;
							case 7:
								num3 = -16;
								continue;
							case 8:
								base.Hide();
								num3 = -6;
								continue;
							case 9:
							{
								RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form6.get_cmdLogin()).MethodHandle;
								num3 = Form7.mqgfoefwabbyeu(32);
								continue;
							}
							case 10:
								goto IL_2F4;
							}
							break;
						}
					}
					IL_2F4:;
				}
				else
				{
					bool flag2 = Operators.ConditionalCompareObjectNotEqual(this.txtPassword.Text, this.rs.Fields["Password"].Value, false);
					if (flag2)
					{
						this.con.Close();
						for (;;)
						{
							int num4 = Form2.uwpnsrqhswlmjh(45);
							for (;;)
							{
								num4 ^= 80;
								switch (num4 + 74)
								{
								case 0:
									num4 = -22;
									continue;
								case 1:
									this.txtPassword.Text = "";
									num4 = -26;
									continue;
								case 2:
									Interaction.MsgBox("Incorrect Password. Please Try Again.", MsgBoxStyle.Exclamation, "Login Error");
									num4 = -25;
									continue;
								case 3:
									num4 = -24;
									continue;
								case 4:
									this.txtPassword.Focus();
									num4 = -20;
									continue;
								case 5:
								{
									RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form6.get_Label1()).MethodHandle;
									num4 = -21;
									continue;
								}
								case 6:
									goto IL_421;
								}
								break;
							}
						}
						IL_421:;
					}
				}
			}
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00019C28 File Offset: 0x00017E28
		private void sbdifomqugmukn(object cu, EventArgs cv)
		{
			for (;;)
			{
				IL_F9:
				int num = Form7.mqgfoefwabbyeu(23);
				int num2 = -9;
				for (;;)
				{
					num2 ^= 77;
					for (;;)
					{
						IL_37:
						int num3 = 9;
						int num4 = 8;
						for (;;)
						{
							switch (num4 ^ 71)
							{
							case 76:
								goto IL_37;
							case 77:
							{
								RuntimeMethodHandle runtimeMethodHandle = methodof(Form6.set_txtUsername(TextBox)).MethodHandle;
								num4 = 10;
								continue;
							}
							case 78:
								switch (num3)
								{
								case 69:
									break;
								case 70:
								{
									RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form6.set_cmdCancel(Button)).MethodHandle;
									num3 = 8;
									goto IL_19;
								}
								case 71:
									switch (num2 + 73)
									{
									case 0:
										switch (num + 75)
										{
										case 0:
											num = -1;
											goto IL_0B;
										case 1:
											num = -10;
											goto IL_0B;
										case 2:
											this.txtPassword.Text = "";
											num = Form12.wsyoqrrjsoniul(58);
											goto IL_0B;
										case 3:
											yupufqwjlhlkfh.whvgmsxtmdbkxx.hcphoarosyelwz.Show();
											num = -2;
											goto IL_0B;
										case 4:
											this.txtUsername.Text = "";
											num = -3;
											goto IL_0B;
										case 5:
										{
											RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form6.get_txtUsername()).MethodHandle;
											num = -14;
											goto IL_0B;
										}
										case 6:
											base.Hide();
											num = -11;
											goto IL_0B;
										case 7:
											num = -13;
											goto IL_0B;
										case 8:
											num = -16;
											goto IL_0B;
										case 9:
											return;
										}
										goto Block_3;
									case 1:
										goto IL_E6;
									case 2:
										goto IL_F9;
									case 3:
										break;
									default:
										num3 = 11;
										goto IL_19;
									}
									IL_0B:
									num ^= 72;
									break;
								case 72:
									goto IL_A8;
								default:
									num4 = 11;
									continue;
								}
								num2 = Form2.uwpnsrqhswlmjh(44);
								num3 = 6;
								goto IL_19;
							case 79:
								goto IL_19;
							}
							IL_32:
							num4 = 9;
							continue;
							IL_19:
							num3 ^= 78;
							goto IL_32;
						}
					}
					IL_A8:
					continue;
					Block_3:
					num2 = -12;
					continue;
					IL_E6:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form6.get_Label1()).MethodHandle;
					num2 = Form7.mqgfoefwabbyeu(27);
				}
			}
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00019E04 File Offset: 0x00018004
		internal static int sbdifomqugmuko(int cw)
		{
			switch (cw - ((-49334482 ^ 421523182) - -365803387 ^ -102854388))
			{
			case 0:
				return ~(116729625 - 199833606 + 608219709 - 525115718 << 2);
			case 2:
				return ~(-(-596914600 + 596911913)) >> 7;
			case 4:
				return -(-263841361 - -704896491) - -441055086;
			case 5:
				return -(-83756329 - -161727649) + -187803468 - -265774745;
			case 6:
				return ~(~498000317) - 498000347;
			case 7:
				return -(~(-105188731 + 105188713));
			case 9:
				return 121652076 ^ -121652096;
			case 12:
				return (~1739135064 - -671532505 ^ 486085459) - -593182899;
			}
			return 330660070 - 266323358 + -64336713;
		}

		// Token: 0x040000CA RID: 202
		private IContainer components;

		// Token: 0x040000D2 RID: 210
		private Connection con;

		// Token: 0x040000D3 RID: 211
		private Recordset rs;
	}
}
