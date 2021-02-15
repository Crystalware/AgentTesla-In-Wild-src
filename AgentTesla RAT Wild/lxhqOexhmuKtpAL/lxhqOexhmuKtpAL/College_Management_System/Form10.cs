using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ADODB;
using College_Management_System.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace College_Management_System
{
	// Token: 0x0200000F RID: 15
	[DesignerGenerated]
	public class Form10 : Form
	{
		// Token: 0x0600005D RID: 93 RVA: 0x00006FDC File Offset: 0x000051DC
		public Form10()
		{
			for (;;)
			{
				IL_C5:
				int num = 2;
				int num2 = 0;
				for (;;)
				{
					num2 ^= 53;
					for (;;)
					{
						IL_3F:
						int num3 = Form7.mqgfoefwabbyeu(24);
						int num4 = 3;
						for (;;)
						{
							switch (num4 ^ 61)
							{
							case 59:
								goto IL_3F;
							case 60:
							{
								RuntimeMethodHandle runtimeMethodHandle = methodof(Form10.get_cmdBack()).MethodHandle;
								num4 = 1;
								continue;
							}
							case 61:
								switch (num3 + 52)
								{
								case 0:
									switch (num2)
									{
									case 50:
										goto IL_B8;
									case 51:
										goto IL_C5;
									case 52:
										switch (num)
										{
										case 54:
											num = 1;
											goto IL_11;
										case 55:
											this.rs = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00000535-0000-0010-8000-00AA006D2EA4")));
											num = 3;
											goto IL_11;
										case 56:
											num = 5;
											goto IL_11;
										case 57:
											this.con = (Connection)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00000514-0000-0010-8000-00AA006D2EA4")));
											num = 15;
											goto IL_11;
										case 58:
											base.Load += this.pdqangwdsoatpn;
											num = 14;
											goto IL_11;
										case 59:
											this.pdqangwdsoatpm();
											num = 0;
											goto IL_11;
										case 60:
										{
											RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form10.set_cmdSave(Button)).MethodHandle;
											num = 4;
											goto IL_11;
										}
										case 61:
											return;
										}
										goto Block_3;
									case 53:
										break;
									default:
										num3 = -4;
										goto IL_22;
									}
									IL_11:
									num ^= 56;
									break;
								case 1:
								{
									RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form10.get_GroupBox1()).MethodHandle;
									num3 = Form7.mqgfoefwabbyeu(25);
									goto IL_22;
								}
								case 2:
									break;
								case 3:
									goto IL_B3;
								default:
									num4 = 6;
									continue;
								}
								num2 = 1;
								num3 = -3;
								goto IL_22;
							case 62:
								goto IL_22;
							}
							IL_3B:
							num4 = 0;
							continue;
							IL_22:
							num3 ^= 50;
							goto IL_3B;
						}
					}
					IL_B3:
					continue;
					IL_B8:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form10.set_cmdAdd(Button)).MethodHandle;
					num2 = 7;
					continue;
					Block_3:
					num2 = 6;
				}
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000071B8 File Offset: 0x000053B8
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
						IL_101:
						int num = 10;
						int num2 = Form12.wsyoqrrjsoniul(53);
						for (;;)
						{
							num2 ^= 58;
							for (;;)
							{
								IL_9D:
								int num3 = Form12.wsyoqrrjsoniul(53);
								int num4 = 126;
								for (;;)
								{
									switch (num4 ^ 62)
									{
									case 61:
										switch (num3 + 53)
										{
										case 0:
											switch (num2 + 59)
											{
											case 0:
												goto IL_101;
											case 1:
												switch (num)
												{
												case 60:
												{
													RuntimeMethodHandle runtimeMethodHandle = methodof(Form10.set_cmdPrevious(Button)).MethodHandle;
													num = 11;
													goto IL_3E;
												}
												case 61:
													this.components.Dispose();
													num = 9;
													goto IL_3E;
												case 62:
													num = 8;
													goto IL_3E;
												case 63:
													goto IL_196;
												}
												goto Block_6;
											case 2:
												goto IL_13A;
											case 3:
												break;
											default:
												num3 = -11;
												goto IL_4F;
											}
											IL_3E:
											num ^= 55;
											break;
										case 1:
											break;
										case 2:
										{
											RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form10.get_Label6()).MethodHandle;
											num3 = Form12.wsyoqrrjsoniul(58);
											goto IL_4F;
										}
										case 3:
											goto IL_FC;
										default:
											num4 = 0;
											continue;
										}
										num2 = Form2.uwpnsrqhswlmjh(42);
										num3 = -9;
										break;
									case 62:
										goto IL_9D;
									case 63:
									{
										RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form10.get_Label1()).MethodHandle;
										num4 = 1;
										continue;
									}
									case 64:
										break;
									default:
										IL_7A:
										num4 = 3;
										continue;
									}
									IL_4F:
									num3 ^= 57;
									goto IL_7A;
								}
							}
							IL_FC:
							continue;
							Block_6:
							num2 = -1;
							continue;
							IL_13A:
							RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form10.set_cmdBack(Button)).MethodHandle;
							num2 = -3;
						}
					}
					IL_196:;
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00007388 File Offset: 0x00005588
		[DebuggerStepThrough]
		private void pdqangwdsoatpm()
		{
			for (;;)
			{
				int num = 14;
				for (;;)
				{
					switch (num ^ 55)
					{
					case 50:
						this.cboSchool.FormattingEnabled = true;
						this.cboSchool.Location = new Point(172, 309);
						this.cboSchool.Name = "cboSchool";
						this.cboSchool.Size = new Size(310, 24);
						this.cboSchool.TabIndex = 152;
						this.txtEmail.Location = new Point(172, 376);
						this.txtEmail.Name = "txtEmail";
						this.txtEmail.Size = new Size(310, 23);
						this.txtEmail.TabIndex = 150;
						this.txtPhone.Location = new Point(172, 343);
						this.txtPhone.Name = "txtPhone";
						this.txtPhone.Size = new Size(310, 23);
						this.txtPhone.TabIndex = 149;
						this.txtLastName.Location = new Point(172, 202);
						num = 115;
						continue;
					case 51:
						base.Controls.Add(this.rbMale);
						base.Controls.Add(this.cmdPhoto);
						base.Controls.Add(this.PictureBox1);
						base.Controls.Add(this.cboSchool);
						base.Controls.Add(this.txtEmail);
						base.Controls.Add(this.txtPhone);
						base.Controls.Add(this.txtLastName);
						base.Controls.Add(this.txtFirstName);
						base.Controls.Add(this.GroupBox1);
						this.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
						base.Margin = new Padding(4, 4, 4, 4);
						base.Name = "Form10";
						this.Text = "Form10";
						this.GroupBox3.ResumeLayout(false);
						num = 124;
						continue;
					case 52:
					{
						RuntimeMethodHandle runtimeMethodHandle = methodof(Form10.set_PictureBox1(PictureBox)).MethodHandle;
						num = 3;
						continue;
					}
					case 53:
						this.GroupBox1.ForeColor = Color.White;
						this.GroupBox1.Location = new Point(23, 441);
						this.GroupBox1.Name = "GroupBox1";
						this.GroupBox1.Size = new Size(447, 112);
						this.GroupBox1.TabIndex = 155;
						this.GroupBox1.TabStop = false;
						this.GroupBox1.Text = "Commands";
						this.OpenFileDialog1.FileName = "OpenFileDialog1";
						base.AutoScaleDimensions = new SizeF(8f, 16f);
						base.AutoScaleMode = AutoScaleMode.Font;
						this.BackColor = Color.SteelBlue;
						base.ClientSize = new Size(788, 569);
						base.Controls.Add(this.GroupBox3);
						base.Controls.Add(this.txtPassword);
						num = 118;
						continue;
					case 54:
						this.Label4 = new Label();
						this.Label3 = new Label();
						this.Label1 = new Label();
						this.GroupBox2 = new GroupBox();
						this.cmdFirst = new Button();
						this.cmdNext = new Button();
						this.cmdPrevious = new Button();
						this.cmdLast = new Button();
						this.cboTitle = new ComboBox();
						this.rbFemale = new RadioButton();
						this.cmdBack = new Button();
						this.DateTimePicker1 = new DateTimePicker();
						this.txtID = new TextBox();
						this.cmdDisplay = new Button();
						num = 15;
						continue;
					case 55:
						this.cmdLast.Name = "cmdLast";
						this.cmdLast.Size = new Size(101, 34);
						this.cmdLast.TabIndex = 83;
						this.cmdLast.Text = "LAST";
						this.cmdLast.UseVisualStyleBackColor = false;
						this.cboTitle.FormattingEnabled = true;
						this.cboTitle.Location = new Point(172, 126);
						this.cboTitle.Name = "cboTitle";
						this.cboTitle.Size = new Size(310, 24);
						this.cboTitle.TabIndex = 158;
						this.rbFemale.AutoSize = true;
						this.rbFemale.ForeColor = Color.White;
						this.rbFemale.Location = new Point(410, 272);
						this.rbFemale.Name = "rbFemale";
						this.rbFemale.Size = new Size(72, 21);
						num = 114;
						continue;
					case 56:
						this.rbMale = new RadioButton();
						this.cmdUpdate = new Button();
						this.cmdPhoto = new Button();
						this.PictureBox1 = new PictureBox();
						this.cboSchool = new ComboBox();
						this.txtEmail = new TextBox();
						this.txtPhone = new TextBox();
						this.txtLastName = new TextBox();
						this.txtFirstName = new TextBox();
						this.GroupBox1 = new GroupBox();
						this.OpenFileDialog1 = new OpenFileDialog();
						this.GroupBox3.SuspendLayout();
						this.GroupBox2.SuspendLayout();
						((ISupportInitialize)this.PictureBox1).BeginInit();
						this.GroupBox1.SuspendLayout();
						num = 125;
						continue;
					case 57:
						this.GroupBox3 = new GroupBox();
						this.Label2 = new Label();
						this.cmdEdit = new Button();
						this.cmdDelete = new Button();
						this.cmdSave = new Button();
						this.cmdAdd = new Button();
						this.cmdSearch = new Button();
						this.txtPassword = new TextBox();
						this.lblPassword = new Label();
						this.Label10 = new Label();
						this.Label9 = new Label();
						this.Label8 = new Label();
						this.Label7 = new Label();
						this.Label6 = new Label();
						this.Label5 = new Label();
						num = 1;
						continue;
					case 58:
						this.Label7.Size = new Size(55, 17);
						this.Label7.TabIndex = 165;
						this.Label7.Text = "School:";
						this.Label6.AutoSize = true;
						this.Label6.ForeColor = Color.White;
						this.Label6.Location = new Point(73, 272);
						this.Label6.Name = "Label6";
						this.Label6.Size = new Size(60, 17);
						this.Label6.TabIndex = 164;
						this.Label6.Text = "Gender:";
						this.Label5.AutoSize = true;
						this.Label5.ForeColor = Color.White;
						this.Label5.Location = new Point(73, 240);
						this.Label5.Name = "Label5";
						num = 8;
						continue;
					case 59:
						this.cmdNext.Name = "cmdNext";
						this.cmdNext.Size = new Size(101, 34);
						this.cmdNext.TabIndex = 57;
						this.cmdNext.Text = "NEXT";
						this.cmdNext.UseVisualStyleBackColor = false;
						this.cmdPrevious.BackColor = Color.BlueViolet;
						this.cmdPrevious.Location = new Point(151, 65);
						this.cmdPrevious.Name = "cmdPrevious";
						this.cmdPrevious.Size = new Size(101, 34);
						this.cmdPrevious.TabIndex = 55;
						this.cmdPrevious.Text = "PREVIOUS";
						this.cmdPrevious.UseVisualStyleBackColor = false;
						this.cmdLast.BackColor = Color.BlueViolet;
						this.cmdLast.Location = new Point(151, 22);
						num = 0;
						continue;
					case 60:
						this.rbMale.ForeColor = Color.White;
						this.rbMale.Location = new Point(172, 272);
						this.rbMale.Name = "rbMale";
						this.rbMale.Size = new Size(56, 21);
						this.rbMale.TabIndex = 156;
						this.rbMale.TabStop = true;
						this.rbMale.Text = "Male";
						this.rbMale.UseVisualStyleBackColor = true;
						this.cmdUpdate.BackColor = Color.BlueViolet;
						this.cmdUpdate.Location = new Point(227, 65);
						this.cmdUpdate.Name = "cmdUpdate";
						this.cmdUpdate.Size = new Size(98, 34);
						this.cmdUpdate.TabIndex = 32;
						this.cmdUpdate.Text = "UPDATE";
						num = 117;
						continue;
					case 61:
						this.lblPassword.Name = "lblPassword";
						this.lblPassword.Size = new Size(73, 17);
						this.lblPassword.TabIndex = 169;
						this.lblPassword.Text = "Password:";
						this.Label10.AutoSize = true;
						this.Label10.ForeColor = Color.White;
						this.Label10.Location = new Point(73, 126);
						this.Label10.Name = "Label10";
						this.Label10.Size = new Size(39, 17);
						this.Label10.TabIndex = 168;
						this.Label10.Text = "Title:";
						this.Label9.AutoSize = true;
						this.Label9.ForeColor = Color.White;
						this.Label9.Location = new Point(73, 379);
						num = 116;
						continue;
					case 62:
						this.GroupBox2.Location = new Point(495, 441);
						this.GroupBox2.Name = "GroupBox2";
						this.GroupBox2.Size = new Size(270, 112);
						this.GroupBox2.TabIndex = 159;
						this.GroupBox2.TabStop = false;
						this.GroupBox2.Text = "Navigation";
						this.cmdFirst.BackColor = Color.BlueViolet;
						this.cmdFirst.Location = new Point(26, 22);
						this.cmdFirst.Name = "cmdFirst";
						this.cmdFirst.Size = new Size(101, 34);
						this.cmdFirst.TabIndex = 82;
						this.cmdFirst.Text = "FIRST";
						this.cmdFirst.UseVisualStyleBackColor = false;
						this.cmdNext.BackColor = Color.BlueViolet;
						this.cmdNext.Location = new Point(26, 65);
						num = 12;
						continue;
					case 63:
						this.Label5.Size = new Size(91, 17);
						this.Label5.TabIndex = 163;
						this.Label5.Text = "Date of Birth:";
						this.Label4.AutoSize = true;
						this.Label4.ForeColor = Color.White;
						this.Label4.Location = new Point(73, 202);
						this.Label4.Name = "Label4";
						this.Label4.Size = new Size(80, 17);
						this.Label4.TabIndex = 162;
						this.Label4.Text = "Last Name:";
						this.Label3.AutoSize = true;
						this.Label3.ForeColor = Color.White;
						this.Label3.Location = new Point(73, 164);
						this.Label3.Name = "Label3";
						this.Label3.Size = new Size(80, 17);
						num = 127;
						continue;
					case 64:
						this.cmdSearch.BackColor = Color.BlueViolet;
						this.cmdSearch.ForeColor = Color.White;
						this.cmdSearch.Location = new Point(331, 22);
						this.cmdSearch.Name = "cmdSearch";
						this.cmdSearch.Size = new Size(98, 34);
						this.cmdSearch.TabIndex = 117;
						this.cmdSearch.Text = "SEARCH";
						this.cmdSearch.UseVisualStyleBackColor = false;
						this.txtPassword.Location = new Point(172, 409);
						this.txtPassword.Name = "txtPassword";
						this.txtPassword.Size = new Size(310, 23);
						this.txtPassword.TabIndex = 170;
						this.lblPassword.AutoSize = true;
						this.lblPassword.ForeColor = Color.White;
						this.lblPassword.Location = new Point(73, 412);
						num = 10;
						continue;
					case 65:
						base.Controls.Add(this.lblPassword);
						for (;;)
						{
							int num2 = 5;
							for (;;)
							{
								switch (num2 ^ 74)
								{
								case 73:
									base.Controls.Add(this.cboTitle);
									num2 = 0;
									continue;
								case 74:
									base.Controls.Add(this.rbFemale);
									num2 = 27;
									continue;
								case 75:
									base.Controls.Add(this.Label4);
									num2 = 24;
									continue;
								case 76:
									base.Controls.Add(this.Label8);
									num2 = 7;
									continue;
								case 77:
									base.Controls.Add(this.Label7);
									num2 = 4;
									continue;
								case 78:
									base.Controls.Add(this.Label6);
									num2 = 26;
									continue;
								case 79:
									base.Controls.Add(this.Label10);
									num2 = 31;
									continue;
								case 80:
									base.Controls.Add(this.Label5);
									num2 = 1;
									continue;
								case 81:
									base.Controls.Add(this.DateTimePicker1);
									num2 = 25;
									continue;
								case 82:
									base.Controls.Add(this.Label3);
									num2 = 28;
									continue;
								case 83:
									base.Controls.Add(this.txtID);
									num2 = 18;
									continue;
								case 84:
								{
									RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form10.set_Label6(Label)).MethodHandle;
									num2 = 30;
									continue;
								}
								case 85:
									base.Controls.Add(this.Label9);
									num2 = 6;
									continue;
								case 86:
									base.Controls.Add(this.Label1);
									num2 = 29;
									continue;
								case 87:
									base.Controls.Add(this.GroupBox2);
									num2 = 3;
									continue;
								case 88:
									goto IL_FC2;
								}
								break;
							}
						}
						IL_FC2:
						num = 4;
						continue;
					case 66:
						this.cmdUpdate.UseVisualStyleBackColor = false;
						this.cmdPhoto.BackColor = Color.BlueViolet;
						this.cmdPhoto.ForeColor = Color.White;
						this.cmdPhoto.Location = new Point(548, 242);
						this.cmdPhoto.Name = "cmdPhoto";
						this.cmdPhoto.Size = new Size(138, 31);
						this.cmdPhoto.TabIndex = 154;
						this.cmdPhoto.Text = "UPLOAD PHOTO";
						this.cmdPhoto.UseVisualStyleBackColor = false;
						this.PictureBox1.BackColor = Color.SteelBlue;
						this.PictureBox1.Location = new Point(514, 86);
						this.PictureBox1.Name = "PictureBox1";
						this.PictureBox1.Size = new Size(200, 150);
						this.PictureBox1.TabIndex = 153;
						this.PictureBox1.TabStop = false;
						num = 5;
						continue;
					case 67:
						this.Label9.Name = "Label9";
						this.Label9.Size = new Size(46, 17);
						this.Label9.TabIndex = 167;
						this.Label9.Text = "Email:";
						this.Label8.AutoSize = true;
						this.Label8.ForeColor = Color.White;
						this.Label8.Location = new Point(73, 343);
						this.Label8.Name = "Label8";
						this.Label8.Size = new Size(75, 17);
						this.Label8.TabIndex = 166;
						this.Label8.Text = "Phone No:";
						this.Label7.AutoSize = true;
						this.Label7.ForeColor = Color.White;
						this.Label7.Location = new Point(73, 309);
						this.Label7.Name = "Label7";
						num = 13;
						continue;
					case 68:
						this.txtLastName.Name = "txtLastName";
						for (;;)
						{
							int num3 = 25;
							for (;;)
							{
								switch (num3 ^ 74)
								{
								case 72:
									this.txtFirstName.Location = new Point(172, 164);
									num3 = 26;
									continue;
								case 73:
									this.GroupBox1.Controls.Add(this.cmdBack);
									num3 = 6;
									continue;
								case 74:
								{
									RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form10.set_txtPassword(TextBox)).MethodHandle;
									num3 = 0;
									continue;
								}
								case 75:
									this.txtFirstName.TabIndex = 147;
									num3 = 3;
									continue;
								case 76:
									this.GroupBox1.Controls.Add(this.cmdEdit);
									num3 = 24;
									continue;
								case 77:
									this.GroupBox1.Controls.Add(this.cmdAdd);
									num3 = 4;
									continue;
								case 78:
									this.GroupBox1.Controls.Add(this.cmdSearch);
									num3 = 29;
									continue;
								case 79:
									this.txtFirstName.Size = new Size(310, 23);
									num3 = 1;
									continue;
								case 80:
									this.txtFirstName.Name = "txtFirstName";
									num3 = 5;
									continue;
								case 81:
									this.GroupBox1.Controls.Add(this.cmdSave);
									num3 = 7;
									continue;
								case 82:
									this.GroupBox1.Controls.Add(this.cmdDisplay);
									num3 = 30;
									continue;
								case 83:
									this.txtLastName.Size = new Size(310, 23);
									num3 = 28;
									continue;
								case 84:
									this.GroupBox1.Controls.Add(this.cmdUpdate);
									num3 = 31;
									continue;
								case 85:
									this.GroupBox1.Controls.Add(this.cmdDelete);
									num3 = 27;
									continue;
								case 86:
									this.txtLastName.TabIndex = 148;
									num3 = 2;
									continue;
								case 87:
									goto IL_1406;
								}
								break;
							}
						}
						IL_1406:
						num = 2;
						continue;
					case 69:
						this.rbFemale.TabIndex = 157;
						this.rbFemale.TabStop = true;
						this.rbFemale.Text = "Female";
						this.rbFemale.UseVisualStyleBackColor = true;
						this.cmdBack.BackColor = Color.BlueViolet;
						this.cmdBack.ForeColor = Color.White;
						this.cmdBack.Location = new Point(331, 65);
						this.cmdBack.Name = "cmdBack";
						this.cmdBack.Size = new Size(98, 34);
						this.cmdBack.TabIndex = 84;
						this.cmdBack.Text = "BACK";
						this.cmdBack.UseVisualStyleBackColor = false;
						this.DateTimePicker1.Location = new Point(172, 240);
						this.DateTimePicker1.Name = "DateTimePicker1";
						num = 113;
						continue;
					case 70:
						this.DateTimePicker1.Size = new Size(310, 23);
						for (;;)
						{
							int num4 = 28;
							for (;;)
							{
								switch (num4 ^ 70)
								{
								case 82:
									this.cmdDisplay.BackColor = Color.BlueViolet;
									num4 = 19;
									continue;
								case 83:
									this.txtID.TabIndex = 146;
									num4 = 20;
									continue;
								case 84:
									this.txtID.Name = "txtID";
									num4 = 24;
									continue;
								case 85:
									this.cmdDisplay.Location = new Point(121, 65);
									num4 = 17;
									continue;
								case 86:
									this.txtID.Location = new Point(172, 86);
									num4 = 18;
									continue;
								case 87:
									this.cmdDisplay.Name = "cmdDisplay";
									num4 = 31;
									continue;
								case 88:
									this.rbMale.AutoSize = true;
									num4 = 39;
									continue;
								case 89:
									this.cmdDisplay.Size = new Size(98, 34);
									num4 = 25;
									continue;
								case 90:
									this.DateTimePicker1.TabIndex = 151;
									num4 = 38;
									continue;
								case 91:
								{
									RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form10.get_cmdLast()).MethodHandle;
									num4 = 29;
									continue;
								}
								case 92:
									this.cmdDisplay.UseVisualStyleBackColor = false;
									num4 = 30;
									continue;
								case 93:
									this.cmdDisplay.Text = "DISPLAY";
									num4 = 26;
									continue;
								case 94:
									this.txtID.Size = new Size(310, 23);
									num4 = 21;
									continue;
								case 95:
									this.cmdDisplay.TabIndex = 58;
									num4 = 27;
									continue;
								case 96:
									this.DateTimePicker1.Value = new DateTime(2017, 4, 8, 0, 0, 0, 0);
									num4 = 16;
									continue;
								case 97:
									goto IL_16F5;
								}
								break;
							}
						}
						IL_16F5:
						num = 11;
						continue;
					case 71:
						this.cmdSave.BackColor = Color.BlueViolet;
						this.cmdSave.Location = new Point(121, 22);
						this.cmdSave.Name = "cmdSave";
						this.cmdSave.Size = new Size(98, 34);
						this.cmdSave.TabIndex = 63;
						this.cmdSave.Text = "SAVE";
						this.cmdSave.UseVisualStyleBackColor = false;
						this.cmdAdd.BackColor = Color.BlueViolet;
						this.cmdAdd.Location = new Point(18, 22);
						this.cmdAdd.Name = "cmdAdd";
						this.cmdAdd.Size = new Size(97, 34);
						this.cmdAdd.TabIndex = 62;
						this.cmdAdd.Text = "ADD NEW";
						this.cmdAdd.UseVisualStyleBackColor = false;
						num = 119;
						continue;
					case 72:
						this.Label3.TabIndex = 161;
						this.Label3.Text = "First Name:";
						this.Label1.AutoSize = true;
						this.Label1.ForeColor = Color.White;
						this.Label1.Location = new Point(73, 86);
						this.Label1.Name = "Label1";
						this.Label1.Size = new Size(82, 17);
						this.Label1.TabIndex = 160;
						this.Label1.Text = "Lecturer ID:";
						this.GroupBox2.Controls.Add(this.cmdFirst);
						this.GroupBox2.Controls.Add(this.cmdNext);
						this.GroupBox2.Controls.Add(this.cmdPrevious);
						this.GroupBox2.Controls.Add(this.cmdLast);
						this.GroupBox2.ForeColor = Color.White;
						num = 9;
						continue;
					case 73:
						this.Label2.Text = "LECTURER PROFILE PAGE";
						this.cmdEdit.BackColor = Color.BlueViolet;
						this.cmdEdit.Location = new Point(227, 22);
						this.cmdEdit.Name = "cmdEdit";
						this.cmdEdit.Size = new Size(98, 34);
						this.cmdEdit.TabIndex = 85;
						this.cmdEdit.Text = "EDIT";
						this.cmdEdit.UseVisualStyleBackColor = false;
						this.cmdDelete.BackColor = Color.BlueViolet;
						this.cmdDelete.Location = new Point(18, 65);
						this.cmdDelete.Name = "cmdDelete";
						this.cmdDelete.Size = new Size(97, 34);
						this.cmdDelete.TabIndex = 64;
						this.cmdDelete.Text = "DELETE";
						this.cmdDelete.UseVisualStyleBackColor = false;
						num = 112;
						continue;
					case 74:
						base.SuspendLayout();
						this.GroupBox3.Controls.Add(this.Label2);
						this.GroupBox3.Location = new Point(184, 15);
						this.GroupBox3.Name = "GroupBox3";
						this.GroupBox3.Size = new Size(411, 53);
						this.GroupBox3.TabIndex = 171;
						this.GroupBox3.TabStop = false;
						this.Label2.AutoSize = true;
						this.Label2.Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Regular, GraphicsUnit.Point, 0);
						this.Label2.ForeColor = Color.White;
						this.Label2.Location = new Point(22, 15);
						this.Label2.Name = "Label2";
						this.Label2.Size = new Size(368, 31);
						this.Label2.TabIndex = 122;
						num = 126;
						continue;
					case 75:
						goto IL_1B22;
					}
					break;
				}
			}
			IL_1B22:
			this.GroupBox3.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			((ISupportInitialize)this.PictureBox1).EndInit();
			this.GroupBox1.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00008F88 File Offset: 0x00007188
		// (set) Token: 0x06000061 RID: 97 RVA: 0x00008F96 File Offset: 0x00007196
		internal virtual GroupBox GroupBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00008FA3 File Offset: 0x000071A3
		// (set) Token: 0x06000063 RID: 99 RVA: 0x00008FB1 File Offset: 0x000071B1
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00008FBE File Offset: 0x000071BE
		// (set) Token: 0x06000065 RID: 101 RVA: 0x00008FCC File Offset: 0x000071CC
		internal virtual Button cmdEdit
		{
			[CompilerGenerated]
			get
			{
				return this._cmdEdit;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.pdqangwdsoatqa);
				Button cmdEdit = this._cmdEdit;
				if (cmdEdit != null)
				{
					cmdEdit.Click -= value2;
				}
				this._cmdEdit = value;
				cmdEdit = this._cmdEdit;
				if (cmdEdit != null)
				{
					cmdEdit.Click += value2;
				}
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00009037 File Offset: 0x00007237
		// (set) Token: 0x06000067 RID: 103 RVA: 0x00009048 File Offset: 0x00007248
		internal virtual Button cmdDelete
		{
			[CompilerGenerated]
			get
			{
				return this._cmdDelete;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.pdqangwdsoatpv);
				Button cmdDelete = this._cmdDelete;
				if (cmdDelete != null)
				{
					cmdDelete.Click -= value2;
				}
				this._cmdDelete = value;
				cmdDelete = this._cmdDelete;
				if (cmdDelete != null)
				{
					cmdDelete.Click += value2;
				}
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000068 RID: 104 RVA: 0x000090B3 File Offset: 0x000072B3
		// (set) Token: 0x06000069 RID: 105 RVA: 0x000090C4 File Offset: 0x000072C4
		internal virtual Button cmdSave
		{
			[CompilerGenerated]
			get
			{
				return this._cmdSave;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.pdqangwdsoatpq);
				Button cmdSave = this._cmdSave;
				if (cmdSave != null)
				{
					cmdSave.Click -= value2;
				}
				this._cmdSave = value;
				cmdSave = this._cmdSave;
				if (cmdSave != null)
				{
					cmdSave.Click += value2;
				}
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600006A RID: 106 RVA: 0x0000912F File Offset: 0x0000732F
		// (set) Token: 0x0600006B RID: 107 RVA: 0x00009140 File Offset: 0x00007340
		internal virtual Button cmdAdd
		{
			[CompilerGenerated]
			get
			{
				return this._cmdAdd;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.pdqangwdsoatpp);
				Button cmdAdd = this._cmdAdd;
				if (cmdAdd != null)
				{
					cmdAdd.Click -= value2;
				}
				this._cmdAdd = value;
				cmdAdd = this._cmdAdd;
				if (cmdAdd != null)
				{
					cmdAdd.Click += value2;
				}
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600006C RID: 108 RVA: 0x000091AB File Offset: 0x000073AB
		// (set) Token: 0x0600006D RID: 109 RVA: 0x000091BC File Offset: 0x000073BC
		internal virtual Button cmdSearch
		{
			[CompilerGenerated]
			get
			{
				return this._cmdSearch;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.pdqangwdsoatpy);
				Button cmdSearch = this._cmdSearch;
				if (cmdSearch != null)
				{
					cmdSearch.Click -= value2;
				}
				this._cmdSearch = value;
				cmdSearch = this._cmdSearch;
				if (cmdSearch != null)
				{
					cmdSearch.Click += value2;
				}
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00009227 File Offset: 0x00007427
		// (set) Token: 0x0600006F RID: 111 RVA: 0x00009235 File Offset: 0x00007435
		internal virtual TextBox txtPassword { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00009242 File Offset: 0x00007442
		// (set) Token: 0x06000071 RID: 113 RVA: 0x00009250 File Offset: 0x00007450
		internal virtual Label lblPassword { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000072 RID: 114 RVA: 0x0000925D File Offset: 0x0000745D
		// (set) Token: 0x06000073 RID: 115 RVA: 0x0000926B File Offset: 0x0000746B
		internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00009278 File Offset: 0x00007478
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00009286 File Offset: 0x00007486
		internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00009293 File Offset: 0x00007493
		// (set) Token: 0x06000077 RID: 119 RVA: 0x000092A1 File Offset: 0x000074A1
		internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000078 RID: 120 RVA: 0x000092AE File Offset: 0x000074AE
		// (set) Token: 0x06000079 RID: 121 RVA: 0x000092BC File Offset: 0x000074BC
		internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600007A RID: 122 RVA: 0x000092C9 File Offset: 0x000074C9
		// (set) Token: 0x0600007B RID: 123 RVA: 0x000092D7 File Offset: 0x000074D7
		internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600007C RID: 124 RVA: 0x000092E4 File Offset: 0x000074E4
		// (set) Token: 0x0600007D RID: 125 RVA: 0x000092F2 File Offset: 0x000074F2
		internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600007E RID: 126 RVA: 0x000092FF File Offset: 0x000074FF
		// (set) Token: 0x0600007F RID: 127 RVA: 0x0000930D File Offset: 0x0000750D
		internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000080 RID: 128 RVA: 0x0000931A File Offset: 0x0000751A
		// (set) Token: 0x06000081 RID: 129 RVA: 0x00009328 File Offset: 0x00007528
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00009335 File Offset: 0x00007535
		// (set) Token: 0x06000083 RID: 131 RVA: 0x00009343 File Offset: 0x00007543
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00009350 File Offset: 0x00007550
		// (set) Token: 0x06000085 RID: 133 RVA: 0x0000935E File Offset: 0x0000755E
		internal virtual GroupBox GroupBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000086 RID: 134 RVA: 0x0000936B File Offset: 0x0000756B
		// (set) Token: 0x06000087 RID: 135 RVA: 0x0000937C File Offset: 0x0000757C
		internal virtual Button cmdFirst
		{
			[CompilerGenerated]
			get
			{
				return this._cmdFirst;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.pdqangwdsoatpr);
				Button cmdFirst = this._cmdFirst;
				if (cmdFirst != null)
				{
					cmdFirst.Click -= value2;
				}
				this._cmdFirst = value;
				cmdFirst = this._cmdFirst;
				if (cmdFirst != null)
				{
					cmdFirst.Click += value2;
				}
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000088 RID: 136 RVA: 0x000093E7 File Offset: 0x000075E7
		// (set) Token: 0x06000089 RID: 137 RVA: 0x000093F8 File Offset: 0x000075F8
		internal virtual Button cmdNext
		{
			[CompilerGenerated]
			get
			{
				return this._cmdNext;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.pdqangwdsoatpt);
				Button cmdNext = this._cmdNext;
				if (cmdNext != null)
				{
					cmdNext.Click -= value2;
				}
				this._cmdNext = value;
				cmdNext = this._cmdNext;
				if (cmdNext != null)
				{
					cmdNext.Click += value2;
				}
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00009463 File Offset: 0x00007663
		// (set) Token: 0x0600008B RID: 139 RVA: 0x00009474 File Offset: 0x00007674
		internal virtual Button cmdPrevious
		{
			[CompilerGenerated]
			get
			{
				return this._cmdPrevious;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.pdqangwdsoatpu);
				Button cmdPrevious = this._cmdPrevious;
				if (cmdPrevious != null)
				{
					cmdPrevious.Click -= value2;
				}
				this._cmdPrevious = value;
				cmdPrevious = this._cmdPrevious;
				if (cmdPrevious != null)
				{
					cmdPrevious.Click += value2;
				}
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600008C RID: 140 RVA: 0x000094DF File Offset: 0x000076DF
		// (set) Token: 0x0600008D RID: 141 RVA: 0x000094F0 File Offset: 0x000076F0
		internal virtual Button cmdLast
		{
			[CompilerGenerated]
			get
			{
				return this._cmdLast;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.pdqangwdsoatps);
				Button cmdLast = this._cmdLast;
				if (cmdLast != null)
				{
					cmdLast.Click -= value2;
				}
				this._cmdLast = value;
				cmdLast = this._cmdLast;
				if (cmdLast != null)
				{
					cmdLast.Click += value2;
				}
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600008E RID: 142 RVA: 0x0000955B File Offset: 0x0000775B
		// (set) Token: 0x0600008F RID: 143 RVA: 0x00009569 File Offset: 0x00007769
		internal virtual ComboBox cboTitle { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00009576 File Offset: 0x00007776
		// (set) Token: 0x06000091 RID: 145 RVA: 0x00009584 File Offset: 0x00007784
		internal virtual RadioButton rbFemale { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00009591 File Offset: 0x00007791
		// (set) Token: 0x06000093 RID: 147 RVA: 0x000095A0 File Offset: 0x000077A0
		internal virtual Button cmdBack
		{
			[CompilerGenerated]
			get
			{
				return this._cmdBack;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.pdqangwdsoatpz);
				Button cmdBack = this._cmdBack;
				if (cmdBack != null)
				{
					cmdBack.Click -= value2;
				}
				this._cmdBack = value;
				cmdBack = this._cmdBack;
				if (cmdBack != null)
				{
					cmdBack.Click += value2;
				}
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000094 RID: 148 RVA: 0x0000960B File Offset: 0x0000780B
		// (set) Token: 0x06000095 RID: 149 RVA: 0x00009619 File Offset: 0x00007819
		internal virtual DateTimePicker DateTimePicker1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00009626 File Offset: 0x00007826
		// (set) Token: 0x06000097 RID: 151 RVA: 0x00009634 File Offset: 0x00007834
		internal virtual TextBox txtID { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00009641 File Offset: 0x00007841
		// (set) Token: 0x06000099 RID: 153 RVA: 0x00009650 File Offset: 0x00007850
		internal virtual Button cmdDisplay
		{
			[CompilerGenerated]
			get
			{
				return this._cmdDisplay;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.pdqangwdsoatpx);
				Button cmdDisplay = this._cmdDisplay;
				if (cmdDisplay != null)
				{
					cmdDisplay.Click -= value2;
				}
				this._cmdDisplay = value;
				cmdDisplay = this._cmdDisplay;
				if (cmdDisplay != null)
				{
					cmdDisplay.Click += value2;
				}
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600009A RID: 154 RVA: 0x000096BB File Offset: 0x000078BB
		// (set) Token: 0x0600009B RID: 155 RVA: 0x000096C9 File Offset: 0x000078C9
		internal virtual RadioButton rbMale { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600009C RID: 156 RVA: 0x000096D6 File Offset: 0x000078D6
		// (set) Token: 0x0600009D RID: 157 RVA: 0x000096E4 File Offset: 0x000078E4
		internal virtual Button cmdUpdate
		{
			[CompilerGenerated]
			get
			{
				return this._cmdUpdate;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.pdqangwdsoatpw);
				Button cmdUpdate = this._cmdUpdate;
				if (cmdUpdate != null)
				{
					cmdUpdate.Click -= value2;
				}
				this._cmdUpdate = value;
				cmdUpdate = this._cmdUpdate;
				if (cmdUpdate != null)
				{
					cmdUpdate.Click += value2;
				}
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600009E RID: 158 RVA: 0x0000974F File Offset: 0x0000794F
		// (set) Token: 0x0600009F RID: 159 RVA: 0x00009760 File Offset: 0x00007960
		internal virtual Button cmdPhoto
		{
			[CompilerGenerated]
			get
			{
				return this._cmdPhoto;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.pdqangwdsoatpo);
				Button cmdPhoto = this._cmdPhoto;
				if (cmdPhoto != null)
				{
					cmdPhoto.Click -= value2;
				}
				this._cmdPhoto = value;
				cmdPhoto = this._cmdPhoto;
				if (cmdPhoto != null)
				{
					cmdPhoto.Click += value2;
				}
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x000097CB File Offset: 0x000079CB
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x000097D9 File Offset: 0x000079D9
		internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x000097E6 File Offset: 0x000079E6
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x000097F4 File Offset: 0x000079F4
		internal virtual ComboBox cboSchool { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00009801 File Offset: 0x00007A01
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x0000980F File Offset: 0x00007A0F
		internal virtual TextBox txtEmail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x0000981C File Offset: 0x00007A1C
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x0000982A File Offset: 0x00007A2A
		internal virtual TextBox txtPhone { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00009837 File Offset: 0x00007A37
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x00009845 File Offset: 0x00007A45
		internal virtual TextBox txtLastName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00009852 File Offset: 0x00007A52
		// (set) Token: 0x060000AB RID: 171 RVA: 0x00009860 File Offset: 0x00007A60
		internal virtual TextBox txtFirstName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000AC RID: 172 RVA: 0x0000986D File Offset: 0x00007A6D
		// (set) Token: 0x060000AD RID: 173 RVA: 0x0000987B File Offset: 0x00007A7B
		internal virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00009888 File Offset: 0x00007A88
		// (set) Token: 0x060000AF RID: 175 RVA: 0x00009896 File Offset: 0x00007A96
		internal virtual OpenFileDialog OpenFileDialog1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x060000B0 RID: 176 RVA: 0x000098A4 File Offset: 0x00007AA4
		private void pdqangwdsoatpn(object p, EventArgs q)
		{
			for (;;)
			{
				IL_106:
				int num = 20;
				int num2 = 8;
				for (;;)
				{
					num2 ^= 69;
					for (;;)
					{
						IL_36:
						int num3 = Form12.wsyoqrrjsoniul(49);
						int num4 = 29;
						for (;;)
						{
							switch (num4 ^ 77)
							{
							case 77:
								goto IL_36;
							case 78:
								switch (num3 + 75)
								{
								case 0:
									break;
								case 1:
									switch (num2)
									{
									case 74:
										goto IL_9B;
									case 75:
										switch (num)
										{
										case 74:
											this.cboSchool.Items.Add("Communication, Language and Performing Arts");
											num = 30;
											goto IL_0B;
										case 75:
											this.cboTitle.Items.Add("Ms");
											num = 28;
											goto IL_0B;
										case 76:
											this.cboTitle.Items.Add("Miss");
											num = 13;
											goto IL_0B;
										case 77:
											this.cboTitle.Items.Add("Mrs.");
											num = 10;
											goto IL_0B;
										case 78:
											num = 9;
											goto IL_0B;
										case 79:
											this.display();
											num = 16;
											goto IL_0B;
										case 80:
											num = 18;
											goto IL_0B;
										case 81:
											this.cboSchool.Items.Add("Arts and Humanities");
											num = 21;
											goto IL_0B;
										case 82:
											this.cboTitle.Items.Add("Prof.");
											num = 19;
											goto IL_0B;
										case 83:
											this.con.Open("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\\Users\\Joey\\Documents\\College.mdb; Persist Security Info = False", "", "", -1);
											num = 22;
											goto IL_0B;
										case 84:
											this.rs.Open("Select * from LecturersProfile", this.con, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
											num = 8;
											goto IL_0B;
										case 85:
											this.cboTitle.Items.Add("Dr.");
											num = 29;
											goto IL_0B;
										case 86:
											num = 26;
											goto IL_0B;
										case 87:
											this.cboSchool.Items.Add("Business and Economics");
											num = 12;
											goto IL_0B;
										case 88:
											this.cboSchool.Items.Add("Human and Social Sciences");
											num = 23;
											goto IL_0B;
										case 89:
										{
											RuntimeMethodHandle runtimeMethodHandle = methodof(Form10.set_lblPassword(Label)).MethodHandle;
											num = 31;
											goto IL_0B;
										}
										case 90:
											this.cboSchool.Items.Add("Science, Engineering and Health");
											num = 17;
											goto IL_0B;
										case 91:
											this.cboTitle.Items.Add("Mr.");
											num = 11;
											goto IL_0B;
										case 92:
											return;
										}
										goto Block_2;
									case 76:
										goto IL_106;
									case 77:
										break;
									default:
										num3 = -27;
										goto IL_19;
									}
									IL_0B:
									num ^= 70;
									break;
								case 2:
								{
									RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form10.pdqangwdsoatpr(object, EventArgs)).MethodHandle;
									num3 = -25;
									goto IL_19;
								}
								case 3:
									goto IL_96;
								default:
									num4 = 0;
									continue;
								}
								num2 = 14;
								num3 = Form12.wsyoqrrjsoniul(41);
								goto IL_19;
							case 79:
							{
								RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form10.get_cmdSearch()).MethodHandle;
								num4 = 2;
								continue;
							}
							case 80:
								goto IL_19;
							}
							IL_32:
							num4 = 3;
							continue;
							IL_19:
							num3 ^= 80;
							goto IL_32;
						}
					}
					IL_96:
					continue;
					IL_9B:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form10.get_Label9()).MethodHandle;
					num2 = 15;
					continue;
					Block_2:
					num2 = 9;
				}
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00009BD4 File Offset: 0x00007DD4
		private void pdqangwdsoatpo(object r, EventArgs s)
		{
			for (;;)
			{
				IL_F2:
				int num = Form2.uwpnsrqhswlmjh(34);
				int num2 = -28;
				for (;;)
				{
					num2 ^= 80;
					for (;;)
					{
						IL_3F:
						int num3 = Form7.mqgfoefwabbyeu(29);
						int num4 = -6;
						for (;;)
						{
							num4 ^= 72;
							switch (num4 + 81)
							{
							case 0:
								goto IL_3F;
							case 1:
								switch (num3 + 72)
								{
								case 0:
								{
									RuntimeMethodHandle runtimeMethodHandle = methodof(Form10.get_txtFirstName()).MethodHandle;
									num3 = -9;
									goto IL_1C;
								}
								case 1:
									switch (num2 + 79)
									{
									case 0:
										switch (num + 81)
										{
										case 0:
											num = -2;
											goto IL_0B;
										case 1:
											this.OpenFileDialog1.Filter = "Jpeg | *.jpg";
											num = -32;
											goto IL_0B;
										case 2:
											this.str = this.OpenFileDialog1.FileName;
											num = -3;
											goto IL_0B;
										case 3:
											this.PictureBox1.Image = Image.FromFile(this.str);
											num = -6;
											goto IL_0B;
										case 4:
										{
											RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form10.get_cmdDelete()).MethodHandle;
											num = Form2.uwpnsrqhswlmjh(42);
											goto IL_0B;
										}
										case 5:
											this.OpenFileDialog1.ShowDialog();
											num = -1;
											goto IL_0B;
										case 6:
											num = -7;
											goto IL_0B;
										case 7:
											return;
										}
										goto Block_2;
									case 1:
										goto IL_E4;
									case 2:
										goto IL_F2;
									case 3:
										break;
									default:
										num3 = -11;
										goto IL_1C;
									}
									IL_0B:
									num ^= 79;
									break;
								case 2:
									break;
								case 3:
									goto IL_AE;
								default:
									num4 = -25;
									continue;
								}
								num2 = Form2.uwpnsrqhswlmjh(47);
								num3 = Form12.wsyoqrrjsoniul(58);
								goto IL_1C;
							case 2:
							{
								RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form10.pdqangwdsoatpz(object, EventArgs)).MethodHandle;
								num4 = Form12.wsyoqrrjsoniul(51);
								continue;
							}
							case 3:
								goto IL_1C;
							}
							IL_35:
							num4 = Form12.wsyoqrrjsoniul(40);
							continue;
							IL_1C:
							num3 ^= 79;
							goto IL_35;
						}
					}
					IL_AE:
					continue;
					Block_2:
					num2 = -29;
					continue;
					IL_E4:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form10.get_cboSchool()).MethodHandle;
					num2 = -30;
				}
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00009DB8 File Offset: 0x00007FB8
		private void pdqangwdsoatpp(object t, EventArgs u)
		{
			for (;;)
			{
				IL_107:
				int num = Form7.mqgfoefwabbyeu(25);
				int num2 = -16;
				for (;;)
				{
					num2 ^= 71;
					for (;;)
					{
						IL_3A:
						int num3 = Form7.mqgfoefwabbyeu(29);
						int num4 = 18;
						for (;;)
						{
							switch (num4 ^ 71)
							{
							case 82:
								goto IL_3A;
							case 83:
							{
								RuntimeMethodHandle runtimeMethodHandle = methodof(Form10.pdqangwdsoatpx(object, EventArgs)).MethodHandle;
								num4 = 20;
								continue;
							}
							case 84:
								switch (num3 + 73)
								{
								case 0:
								{
									RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form10.get_Label3()).MethodHandle;
									num3 = -8;
									goto IL_1C;
								}
								case 1:
									break;
								case 2:
									switch (num2 + 76)
									{
									case 0:
										switch (num + 76)
										{
										case 0:
											this.txtPassword.Visible = true;
											num = -8;
											goto IL_0B;
										case 1:
											num = -5;
											goto IL_0B;
										case 2:
											num = -2;
											goto IL_0B;
										case 3:
											num = Form7.mqgfoefwabbyeu(31);
											goto IL_0B;
										case 4:
											this.lblPassword.Visible = true;
											num = -4;
											goto IL_0B;
										case 5:
											num = -15;
											goto IL_0B;
										case 6:
											this.rs.AddNew(RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
											num = -13;
											goto IL_0B;
										case 7:
											this.clear();
											num = -16;
											goto IL_0B;
										case 8:
										{
											RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form10.pdqangwdsoatqa(object, EventArgs)).MethodHandle;
											num = -7;
											goto IL_0B;
										}
										case 9:
											num = -6;
											goto IL_0B;
										case 10:
											this.PictureBox1.BorderStyle = BorderStyle.FixedSingle;
											num = -14;
											goto IL_0B;
										case 11:
											return;
										}
										goto Block_3;
									case 1:
										goto IL_F9;
									case 2:
										goto IL_107;
									case 3:
										break;
									default:
										num3 = -9;
										goto IL_1C;
									}
									IL_0B:
									num ^= 69;
									break;
								case 3:
									goto IL_B3;
								default:
									num4 = 21;
									continue;
								}
								num2 = Form7.mqgfoefwabbyeu(21);
								num3 = -11;
								goto IL_1C;
							case 85:
								goto IL_1C;
							}
							IL_35:
							num4 = 19;
							continue;
							IL_1C:
							num3 ^= 79;
							goto IL_35;
						}
					}
					IL_B3:
					continue;
					Block_3:
					num2 = -15;
					continue;
					IL_F9:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form10.set_txtPhone(TextBox)).MethodHandle;
					num2 = -14;
				}
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00009FC8 File Offset: 0x000081C8
		public void clear()
		{
			for (;;)
			{
				IL_10E:
				int num = 26;
				int num2 = -15;
				for (;;)
				{
					num2 ^= 73;
					for (;;)
					{
						IL_49:
						int num3 = Form12.wsyoqrrjsoniul(43);
						int num4 = -7;
						for (;;)
						{
							num4 ^= 76;
							switch (num4 + 78)
							{
							case 0:
								switch (num3 + 71)
								{
								case 0:
									break;
								case 1:
									switch (num2 + 75)
									{
									case 0:
										goto IL_B2;
									case 1:
										switch (num)
										{
										case 75:
											this.DateTimePicker1.Value = DateTime.Today;
											num = 3;
											goto IL_0B;
										case 76:
											this.txtLastName.Text = "";
											num = 5;
											goto IL_0B;
										case 77:
											this.rbMale.Checked = false;
											num = 30;
											goto IL_0B;
										case 78:
										{
											RuntimeMethodHandle runtimeMethodHandle = methodof(Form10.set_Label6(Label)).MethodHandle;
											num = 0;
											goto IL_0B;
										}
										case 79:
											this.cboSchool.Text = "";
											num = 27;
											goto IL_0B;
										case 80:
											this.rbFemale.Checked = false;
											num = 1;
											goto IL_0B;
										case 81:
											this.PictureBox1.Image = null;
											num = 25;
											goto IL_0B;
										case 82:
											this.txtFirstName.Text = "";
											num = 2;
											goto IL_0B;
										case 83:
											this.txtEmail.Text = "";
											num = 31;
											goto IL_0B;
										case 84:
											this.txtID.Text = "";
											num = 24;
											goto IL_0B;
										case 85:
											this.txtPhone.Text = "";
											num = 29;
											goto IL_0B;
										case 86:
											this.cboTitle.Text = "";
											num = 28;
											goto IL_0B;
										case 87:
											this.txtPassword.Text = "";
											num = 22;
											goto IL_0B;
										case 88:
											return;
										}
										goto Block_2;
									case 2:
										goto IL_10E;
									case 3:
										break;
									default:
										num3 = -23;
										goto IL_19;
									}
									IL_0B:
									num ^= 78;
									break;
								case 2:
								{
									RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form10.set_GroupBox1(GroupBox)).MethodHandle;
									num3 = Form6.sbdifomqugmuko(57);
									goto IL_19;
								}
								case 3:
									goto IL_AD;
								default:
									num4 = -1;
									continue;
								}
								num2 = Form7.mqgfoefwabbyeu(25);
								num3 = -20;
								goto IL_19;
							case 1:
								goto IL_49;
							case 2:
							{
								RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form10.set_Label8(Label)).MethodHandle;
								num4 = Form12.wsyoqrrjsoniul(40);
								continue;
							}
							case 3:
								goto IL_19;
							}
							IL_32:
							num4 = Form7.mqgfoefwabbyeu(24);
							continue;
							IL_19:
							num3 ^= 80;
							goto IL_32;
						}
					}
					IL_AD:
					continue;
					IL_B2:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form10.set_cmdPhoto(Button)).MethodHandle;
					num2 = -4;
					continue;
					Block_2:
					num2 = Form7.mqgfoefwabbyeu(24);
				}
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000A264 File Offset: 0x00008464
		public void display()
		{
			for (;;)
			{
				IL_B4:
				int num = 27;
				int num2 = 0;
				for (;;)
				{
					num2 ^= 82;
					for (;;)
					{
						int num3 = Form12.wsyoqrrjsoniul(53);
						for (;;)
						{
							num3 ^= 70;
							switch (num3 + 76)
							{
							case 0:
								switch (num2)
								{
								case 79:
									switch (num)
									{
									case 71:
										this.cboTitle.Text = Conversions.ToString(this.rs.Fields["Title"].Value);
										num = 30;
										goto IL_0B;
									case 72:
									{
										RuntimeMethodHandle runtimeMethodHandle = methodof(Form10.get_Label10()).MethodHandle;
										num = 25;
										goto IL_0B;
									}
									case 73:
										num = 29;
										goto IL_0B;
									case 74:
										this.txtID.Text = Conversions.ToString(this.rs.Fields["LecturerID"].Value);
										num = 28;
										goto IL_0B;
									case 75:
										this.DateTimePicker1.Value = Conversions.ToDate(this.rs.Fields["DOB"].Value);
										num = 24;
										goto IL_0B;
									case 76:
									{
										bool flag = Operators.ConditionalCompareObjectEqual(this.rs.Fields["Gender"].Value, this.rbMale.Text, false);
										num = 2;
										goto IL_0B;
									}
									case 77:
										num = 22;
										goto IL_0B;
									case 78:
										this.txtFirstName.Text = Conversions.ToString(this.rs.Fields["FirstName"].Value);
										num = 3;
										goto IL_0B;
									case 79:
										num = 31;
										goto IL_0B;
									case 80:
										num = 26;
										goto IL_0B;
									case 81:
										this.txtLastName.Text = Conversions.ToString(this.rs.Fields["LastName"].Value);
										num = 1;
										goto IL_0B;
									case 82:
										num = 0;
										goto IL_0B;
									case 83:
									{
										bool flag;
										if (flag)
										{
											num = 5;
											goto IL_0B;
										}
										goto IL_244;
									}
									case 84:
										goto IL_241;
									}
									goto Block_1;
								case 80:
									goto IL_B4;
								case 81:
									goto IL_BF;
								case 82:
									break;
								default:
									num3 = -16;
									continue;
								}
								IL_0B:
								num ^= 81;
								goto IL_5A;
							case 1:
							{
								RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form10.set_cmdPhoto(Button)).MethodHandle;
								num3 = -13;
								continue;
							}
							case 2:
								goto IL_5A;
							case 3:
								goto IL_69;
							}
							break;
							IL_5A:
							num2 = 29;
							num3 = Form7.mqgfoefwabbyeu(23);
						}
					}
					IL_69:
					continue;
					Block_1:
					num2 = 2;
					continue;
					IL_BF:
					RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form10.set_Label3(Label)).MethodHandle;
					num2 = 3;
				}
			}
			IL_241:
			bool flag2 = false;
			goto IL_247;
			IL_244:
			flag2 = true;
			IL_247:
			if (!flag2)
			{
				this.rbMale.Checked = true;
			}
			else
			{
				bool flag3 = Operators.ConditionalCompareObjectEqual(this.rs.Fields["Gender"].Value, this.rbFemale.Text, false);
				if (flag3)
				{
					this.rbFemale.Checked = true;
				}
			}
			this.cboSchool.Text = Conversions.ToString(this.rs.Fields["School"].Value);
			for (;;)
			{
				int num4 = Form7.mqgfoefwabbyeu(27);
				for (;;)
				{
					num4 ^= 78;
					switch (num4 + 77)
					{
					case 0:
						num4 = Form7.mqgfoefwabbyeu(32);
						continue;
					case 1:
						this.txtPassword.Text = Conversions.ToString(this.rs.Fields["Password"].Value);
						num4 = -3;
						continue;
					case 2:
						this.txtPhone.Text = Conversions.ToString(this.rs.Fields["PhoneNo"].Value);
						num4 = -7;
						continue;
					case 3:
						num4 = -12;
						continue;
					case 4:
						num4 = -15;
						continue;
					case 5:
					{
						RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form10.set_cmdDisplay(Button)).MethodHandle;
						num4 = -10;
						continue;
					}
					case 6:
						this.lblPassword.Visible = false;
						num4 = -14;
						continue;
					case 7:
						this.PictureBox1.Image = Image.FromFile(Conversions.ToString(this.rs.Fields["Photo"].Value));
						num4 = -114;
						continue;
					case 8:
						num4 = -5;
						continue;
					case 9:
						num4 = -13;
						continue;
					case 10:
						this.txtPassword.Visible = false;
						num4 = -16;
						continue;
					case 11:
						num4 = -113;
						continue;
					case 12:
						this.txtEmail.Text = Conversions.ToString(this.rs.Fields["Email"].Value);
						num4 = -8;
						continue;
					case 13:
						num4 = -6;
						continue;
					case 14:
						return;
					}
					break;
				}
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000A71C File Offset: 0x0000891C
		public void refreshData()
		{
			for (;;)
			{
				IL_6F:
				int num = Form12.wsyoqrrjsoniul(43);
				int num2 = -5;
				for (;;)
				{
					num2 ^= 79;
					for (;;)
					{
						int num3 = 3;
						for (;;)
						{
							switch (num3 ^ 89)
							{
							case 88:
							{
								RuntimeMethodHandle runtimeMethodHandle = methodof(Form10.set_rbFemale(RadioButton)).MethodHandle;
								num3 = 1;
								continue;
							}
							case 89:
								goto IL_3E;
							case 90:
								switch (num2 + 79)
								{
								case 0:
									goto IL_6F;
								case 1:
									switch (num + 71)
									{
									case 0:
										num = -18;
										goto IL_08;
									case 1:
										num = -17;
										goto IL_08;
									case 2:
										this.rs.Close();
										num = -24;
										goto IL_08;
									case 3:
									{
										RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form10.get_cmdAdd()).MethodHandle;
										num = -19;
										goto IL_08;
									}
									case 4:
									{
										bool flag;
										if (flag)
										{
											num = -111;
											goto IL_08;
										}
										goto IL_143;
									}
									case 5:
									{
										bool flag = !this.rs.EOF;
										num = Form6.sbdifomqugmuko(64);
										goto IL_08;
									}
									case 6:
										this.rs.Open("Select * from LecturersProfile", this.con, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockPessimistic, -1);
										num = -21;
										goto IL_08;
									case 7:
										goto IL_140;
									}
									goto Block_2;
								case 2:
									goto IL_B2;
								case 3:
									break;
								default:
									num3 = 0;
									continue;
								}
								IL_08:
								num ^= 81;
								goto IL_3E;
							case 91:
								goto IL_6D;
							}
							break;
							IL_3E:
							num2 = Form7.mqgfoefwabbyeu(31);
							num3 = 2;
						}
					}
					IL_6D:
					continue;
					Block_2:
					num2 = Form7.mqgfoefwabbyeu(24);
					continue;
					IL_B2:
					RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form10.set_GroupBox3(GroupBox)).MethodHandle;
					num2 = -4;
				}
			}
			IL_140:
			bool flag2 = false;
			goto IL_146;
			IL_143:
			flag2 = true;
			IL_146:
			if (!flag2)
			{
				this.rs.MoveNext();
				for (;;)
				{
					int num4 = Form12.wsyoqrrjsoniul(40);
					for (;;)
					{
						num4 ^= 87;
						switch (num4 + 81)
						{
						case 0:
							num4 = -28;
							continue;
						case 1:
							num4 = -27;
							continue;
						case 2:
						{
							RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form10.set_cmdAdd(Button)).MethodHandle;
							num4 = -26;
							continue;
						}
						case 3:
							num4 = Form12.wsyoqrrjsoniul(52);
							continue;
						case 4:
							this.display();
							num4 = -25;
							continue;
						case 5:
							goto IL_1E4;
						}
						break;
					}
				}
				IL_1E4:;
			}
			else
			{
				Interaction.MsgBox("Record Not Found.", MsgBoxStyle.Information, null);
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000A928 File Offset: 0x00008B28
		public void reload()
		{
			for (;;)
			{
				IL_CE:
				int num = Form12.wsyoqrrjsoniul(58);
				int num2 = -24;
				for (;;)
				{
					num2 ^= 90;
					for (;;)
					{
						IL_53:
						int num3 = 9;
						int num4 = 9;
						for (;;)
						{
							switch (num4 ^ 82)
							{
							case 88:
							{
								RuntimeMethodHandle runtimeMethodHandle = methodof(Form10.get_lblPassword()).MethodHandle;
								num4 = 10;
								continue;
							}
							case 89:
								switch (num3)
								{
								case 81:
									break;
								case 82:
								{
									RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form10.get_lblPassword()).MethodHandle;
									num3 = 8;
									goto IL_19;
								}
								case 83:
									switch (num2 + 81)
									{
									case 0:
										switch (num + 84)
										{
										case 0:
										{
											RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form10.get_Label5()).MethodHandle;
											num = -9;
											goto IL_0B;
										}
										case 1:
											num = -21;
											goto IL_0B;
										case 2:
											num = Form12.wsyoqrrjsoniul(43);
											goto IL_0B;
										case 3:
											this.rs.Close();
											num = -10;
											goto IL_0B;
										case 4:
											this.rs.Open("Select * from LecturersProfile", this.con, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
											num = -11;
											goto IL_0B;
										case 5:
											return;
										}
										goto Block_2;
									case 1:
										goto IL_C0;
									case 2:
										goto IL_CE;
									case 3:
										break;
									default:
										num3 = 11;
										goto IL_19;
									}
									IL_0B:
									num ^= 91;
									break;
								case 84:
									goto IL_92;
								default:
									num4 = 8;
									continue;
								}
								num2 = Form7.mqgfoefwabbyeu(27);
								num3 = 14;
								goto IL_19;
							case 90:
								goto IL_53;
							case 91:
								goto IL_19;
							}
							IL_32:
							num4 = 11;
							continue;
							IL_19:
							num3 ^= 90;
							goto IL_32;
						}
					}
					IL_92:
					continue;
					Block_2:
					num2 = -21;
					continue;
					IL_C0:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form10.get_cmdSearch()).MethodHandle;
					num2 = -22;
				}
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000AABC File Offset: 0x00008CBC
		private void pdqangwdsoatpq(object v, EventArgs w)
		{
			for (;;)
			{
				int num = 2;
				for (;;)
				{
					switch (num ^ 87)
					{
					case 84:
						this.rs.Fields["DOB"].Value = this.DateTimePicker1.Value;
						num = 12;
						continue;
					case 85:
						this.rs.Fields["LecturerID"].Value = this.txtID.Text;
						num = 55;
						continue;
					case 86:
					{
						RuntimeMethodHandle runtimeMethodHandle = methodof(Form10.set_cmdNext(Button)).MethodHandle;
						num = 1;
						continue;
					}
					case 87:
					{
						bool @checked;
						if (@checked)
						{
							num = 54;
							continue;
						}
						goto IL_16A;
					}
					case 88:
						this.rs.Fields["FirstName"].Value = this.txtFirstName.Text;
						num = 8;
						continue;
					case 89:
						this.rs.Fields["LastName"].Value = this.txtLastName.Text;
						num = 10;
						continue;
					case 90:
						num = 15;
						continue;
					case 91:
						num = 11;
						continue;
					case 92:
					{
						bool @checked = this.rbMale.Checked;
						num = 0;
						continue;
					}
					case 93:
						num = 3;
						continue;
					case 94:
						this.rs.Fields["Title"].Value = this.cboTitle.Text;
						num = 13;
						continue;
					case 95:
						num = 14;
						continue;
					case 96:
						num = 9;
						continue;
					case 97:
						goto IL_167;
					}
					break;
				}
			}
			IL_167:
			bool flag = false;
			goto IL_16D;
			IL_16A:
			flag = true;
			IL_16D:
			if (!flag)
			{
				this.rs.Fields["Gender"].Value = this.rbMale.Text;
				for (;;)
				{
					int num2 = 11;
					for (;;)
					{
						switch (num2 ^ 80)
						{
						case 89:
						{
							RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form10..ctor()).MethodHandle;
							num2 = 9;
							continue;
						}
						case 90:
							num2 = 12;
							continue;
						case 91:
							num2 = 10;
							continue;
						case 92:
							goto IL_1D7;
						}
						break;
					}
				}
				IL_1D7:;
			}
			else
			{
				bool checked2 = this.rbFemale.Checked;
				if (checked2)
				{
					this.rs.Fields["Gender"].Value = this.rbFemale.Text;
				}
			}
			this.rs.Fields["School"].Value = this.cboSchool.Text;
			for (;;)
			{
				int num3 = Form6.sbdifomqugmuko(64);
				for (;;)
				{
					num3 ^= 91;
					switch (num3 + 79)
					{
					case 0:
						num3 = -17;
						continue;
					case 1:
					{
						bool flag2;
						if (flag2)
						{
							num3 = -26;
							continue;
						}
						goto IL_39E;
					}
					case 2:
						num3 = -25;
						continue;
					case 3:
						this.rs.Fields["Password"].Value = this.txtPassword.Text;
						num3 = -19;
						continue;
					case 4:
						num3 = -30;
						continue;
					case 5:
						num3 = -31;
						continue;
					case 6:
						num3 = -29;
						continue;
					case 7:
						this.rs.Fields["PhoneNo"].Value = this.txtPhone.Text;
						num3 = Form12.wsyoqrrjsoniul(41);
						continue;
					case 8:
						this.rs.Fields["Photo"].Value = this.str;
						num3 = -22;
						continue;
					case 9:
					{
						bool flag2 = Operators.CompareString(this.str, "", false) == 0;
						num3 = -23;
						continue;
					}
					case 10:
					{
						RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form10.set_Label1(Label)).MethodHandle;
						num3 = -32;
						continue;
					}
					case 11:
						this.rs.Fields["Email"].Value = this.txtEmail.Text;
						num3 = -18;
						continue;
					case 12:
						goto IL_39B;
					}
					break;
				}
			}
			IL_39B:
			bool flag3 = false;
			goto IL_3A1;
			IL_39E:
			flag3 = true;
			IL_3A1:
			if (!flag3)
			{
				Interaction.MsgBox("Please Upload a Photo for the Lecturer.", MsgBoxStyle.Critical, null);
			}
			else
			{
				for (;;)
				{
					int num4 = 13;
					for (;;)
					{
						switch (num4 ^ 80)
						{
						case 92:
							this.rs.Update(RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
							num4 = 15;
							continue;
						case 93:
							Interaction.MsgBox("Record Saved Successfully.", MsgBoxStyle.Information, null);
							num4 = 12;
							continue;
						case 94:
						{
							RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form10.get_cmdLast()).MethodHandle;
							num4 = 14;
							continue;
						}
						case 95:
							num4 = 48;
							continue;
						case 96:
							goto IL_49F;
						}
						break;
					}
				}
				IL_49F:;
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000AF6C File Offset: 0x0000916C
		private void pdqangwdsoatpr(object x, EventArgs y)
		{
			for (;;)
			{
				IL_DE:
				int num = 2;
				int num2 = -2;
				for (;;)
				{
					num2 ^= 82;
					for (;;)
					{
						IL_3C:
						int num3 = 7;
						int num4 = -3;
						for (;;)
						{
							num4 ^= 81;
							switch (num4 + 87)
							{
							case 0:
								goto IL_3C;
							case 1:
								switch (num3)
								{
								case 85:
								{
									RuntimeMethodHandle runtimeMethodHandle = methodof(Form10.set_txtPassword(TextBox)).MethodHandle;
									num3 = 5;
									goto IL_19;
								}
								case 86:
									break;
								case 87:
									switch (num2 + 87)
									{
									case 0:
										goto IL_A2;
									case 1:
										switch (num)
										{
										case 88:
											this.rs.MoveFirst();
											num = 3;
											goto IL_0B;
										case 89:
											num = 6;
											goto IL_0B;
										case 90:
										{
											RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form10.pdqangwdsoatpm()).MethodHandle;
											num = 0;
											goto IL_0B;
										}
										case 91:
											num = 7;
											goto IL_0B;
										case 92:
											this.display();
											num = 1;
											goto IL_0B;
										case 93:
											return;
										}
										goto Block_2;
									case 2:
										goto IL_DE;
									case 3:
										break;
									default:
										num3 = 6;
										goto IL_19;
									}
									IL_0B:
									num ^= 90;
									break;
								case 88:
									goto IL_9D;
								default:
									num4 = -8;
									continue;
								}
								num2 = Form12.wsyoqrrjsoniul(40);
								num3 = 8;
								goto IL_19;
							case 2:
							{
								RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form10.pdqangwdsoatpp(object, EventArgs)).MethodHandle;
								num4 = Form2.uwpnsrqhswlmjh(44);
								continue;
							}
							case 3:
								goto IL_19;
							}
							IL_32:
							num4 = Form2.uwpnsrqhswlmjh(34);
							continue;
							IL_19:
							num3 ^= 80;
							goto IL_32;
						}
					}
					IL_9D:
					continue;
					IL_A2:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form10.pdqangwdsoatpm()).MethodHandle;
					num2 = Form2.uwpnsrqhswlmjh(34);
					continue;
					Block_2:
					num2 = -7;
				}
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000B0EC File Offset: 0x000092EC
		private void pdqangwdsoatps(object z, EventArgs aa)
		{
			for (;;)
			{
				IL_BF:
				int num = 15;
				int num2 = 0;
				for (;;)
				{
					num2 ^= 91;
					for (;;)
					{
						IL_54:
						int num3 = Form7.mqgfoefwabbyeu(23);
						int num4 = 6;
						for (;;)
						{
							switch (num4 ^ 82)
							{
							case 81:
							{
								RuntimeMethodHandle runtimeMethodHandle = methodof(Form10.pdqangwdsoatpr(object, EventArgs)).MethodHandle;
								num4 = 3;
								continue;
							}
							case 82:
								switch (num3 + 88)
								{
								case 0:
									switch (num2)
									{
									case 88:
										switch (num)
										{
										case 91:
										{
											RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form10.set_txtEmail(TextBox)).MethodHandle;
											num = 8;
											goto IL_0B;
										}
										case 92:
											this.rs.MoveLast();
											num = 12;
											goto IL_0B;
										case 93:
											this.display();
											num = 13;
											goto IL_0B;
										case 94:
											num = 51;
											goto IL_0B;
										case 95:
											num = 14;
											goto IL_0B;
										case 96:
											return;
										}
										goto Block_2;
									case 89:
										goto IL_BF;
									case 90:
										goto IL_C9;
									case 91:
										break;
									default:
										num3 = -13;
										goto IL_1C;
									}
									IL_0B:
									num ^= 83;
									break;
								case 1:
								{
									RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form10.get_cmdSave()).MethodHandle;
									num3 = -16;
									goto IL_1C;
								}
								case 2:
									break;
								case 3:
									goto IL_92;
								default:
									num4 = 1;
									continue;
								}
								num2 = 3;
								num3 = -14;
								goto IL_1C;
							case 83:
								goto IL_54;
							case 84:
								goto IL_1C;
							}
							IL_35:
							num4 = 0;
							continue;
							IL_1C:
							num3 ^= 89;
							goto IL_35;
						}
					}
					IL_92:
					continue;
					Block_2:
					num2 = 2;
					continue;
					IL_C9:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form10.get_cmdUpdate()).MethodHandle;
					num2 = 1;
				}
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000B25C File Offset: 0x0000945C
		private void pdqangwdsoatpt(object ab, EventArgs ac)
		{
			for (;;)
			{
				IL_87:
				int num = 5;
				int num2 = 3;
				for (;;)
				{
					num2 ^= 92;
					for (;;)
					{
						int num3 = 6;
						for (;;)
						{
							switch (num3 ^ 86)
							{
							case 80:
								switch (num2)
								{
								case 92:
									goto IL_58;
								case 93:
									switch (num)
									{
									case 88:
										num = 6;
										goto IL_0B;
									case 89:
										this.rs.MoveNext();
										num = 4;
										goto IL_0B;
									case 90:
									{
										bool flag = !this.rs.EOF;
										num = 0;
										goto IL_0B;
									}
									case 91:
									{
										RuntimeMethodHandle runtimeMethodHandle = methodof(Form10.get_cmdNext()).MethodHandle;
										num = 7;
										goto IL_0B;
									}
									case 92:
									{
										bool flag;
										if (flag)
										{
											num = 1;
											goto IL_0B;
										}
										goto IL_DC;
									}
									case 93:
										goto IL_D9;
									}
									goto Block_1;
								case 94:
									goto IL_87;
								case 95:
									break;
								default:
									num3 = 4;
									continue;
								}
								IL_0B:
								num ^= 92;
								goto IL_4F;
							case 81:
							{
								RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form10.pdqangwdsoatpn(object, EventArgs)).MethodHandle;
								num3 = 7;
								continue;
							}
							case 82:
								goto IL_4F;
							case 83:
								goto IL_56;
							}
							break;
							IL_4F:
							num2 = 1;
							num3 = 5;
						}
					}
					IL_56:
					continue;
					IL_58:
					RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form10.get_Label5()).MethodHandle;
					num2 = 0;
					continue;
					Block_1:
					num2 = 2;
				}
			}
			IL_D9:
			bool flag2 = false;
			goto IL_DF;
			IL_DC:
			flag2 = true;
			IL_DF:
			if (!flag2)
			{
				this.display();
			}
			else
			{
				for (;;)
				{
					int num4 = 14;
					for (;;)
					{
						switch (num4 ^ 81)
						{
						case 92:
							num4 = 15;
							continue;
						case 93:
							num4 = 48;
							continue;
						case 94:
							this.display();
							num4 = 12;
							continue;
						case 95:
							this.rs.MoveFirst();
							num4 = 13;
							continue;
						case 96:
						{
							RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form10.set_DateTimePicker1(DateTimePicker)).MethodHandle;
							num4 = 49;
							continue;
						}
						case 97:
							goto IL_19D;
						}
						break;
					}
				}
				IL_19D:;
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000B408 File Offset: 0x00009608
		private void pdqangwdsoatpu(object ad, EventArgs ae)
		{
			for (;;)
			{
				IL_64:
				int num = 7;
				int num2 = -22;
				for (;;)
				{
					num2 ^= 91;
					for (;;)
					{
						int num3 = Form7.mqgfoefwabbyeu(31);
						for (;;)
						{
							num3 ^= 86;
							switch (num3 + 86)
							{
							case 0:
							{
								RuntimeMethodHandle runtimeMethodHandle = methodof(Form10.display()).MethodHandle;
								num3 = -4;
								continue;
							}
							case 1:
								switch (num2 + 82)
								{
								case 0:
									goto IL_64;
								case 1:
									switch (num)
									{
									case 82:
									{
										bool bof = this.rs.BOF;
										num = 2;
										goto IL_08;
									}
									case 83:
									{
										bool bof;
										if (bof)
										{
											num = 6;
											goto IL_08;
										}
										goto IL_F3;
									}
									case 84:
										num = 3;
										goto IL_08;
									case 85:
									{
										RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form10.set_cmdSave(Button)).MethodHandle;
										num = 4;
										goto IL_08;
									}
									case 86:
										this.rs.MovePrevious();
										num = 5;
										goto IL_08;
									case 87:
										goto IL_F0;
									}
									goto Block_1;
								case 2:
									goto IL_94;
								case 3:
									break;
								default:
									num3 = -6;
									continue;
								}
								IL_08:
								num ^= 81;
								goto IL_54;
							case 2:
								goto IL_54;
							case 3:
								goto IL_62;
							}
							break;
							IL_54:
							num2 = Form12.wsyoqrrjsoniul(58);
							num3 = -5;
						}
					}
					IL_62:
					continue;
					Block_1:
					num2 = -11;
					continue;
					IL_94:
					RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form10.get_Label10()).MethodHandle;
					num2 = Form6.sbdifomqugmuko(57);
				}
			}
			IL_F0:
			bool flag = false;
			goto IL_F6;
			IL_F3:
			flag = true;
			IL_F6:
			if (!flag)
			{
				this.rs.MoveLast();
				for (;;)
				{
					int num4 = 1;
					for (;;)
					{
						switch (num4 ^ 88)
						{
						case 89:
							num4 = 5;
							continue;
						case 90:
							num4 = 6;
							continue;
						case 91:
							num4 = 2;
							continue;
						case 92:
						{
							RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form10.get_cmdDelete()).MethodHandle;
							num4 = 4;
							continue;
						}
						case 93:
							this.display();
							num4 = 3;
							continue;
						case 94:
							goto IL_179;
						}
						break;
					}
				}
				IL_179:;
			}
			else
			{
				this.display();
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000B5C0 File Offset: 0x000097C0
		private void pdqangwdsoatpv(object af, EventArgs ag)
		{
			for (;;)
			{
				IL_A1:
				int num = Form7.mqgfoefwabbyeu(19);
				int num2 = Form2.uwpnsrqhswlmjh(47);
				for (;;)
				{
					num2 ^= 82;
					for (;;)
					{
						int num3 = Form2.uwpnsrqhswlmjh(44);
						for (;;)
						{
							num3 ^= 86;
							switch (num3 + 84)
							{
							case 0:
								switch (num2 + 80)
								{
								case 0:
									goto IL_6F;
								case 1:
									switch (num + 88)
									{
									case 0:
									{
										string value = Conversions.ToString((int)Interaction.MsgBox("Do You Really Want to Delete This Lecturer Profile?", MsgBoxStyle.YesNo | MsgBoxStyle.Critical, "Deletion Confirmation"));
										num = -15;
										goto IL_0B;
									}
									case 1:
									{
										string value;
										bool flag = Conversions.ToDouble(value) == 6.0;
										num = Form7.mqgfoefwabbyeu(21);
										goto IL_0B;
									}
									case 2:
									{
										RuntimeMethodHandle runtimeMethodHandle = methodof(Form10.get_cboTitle()).MethodHandle;
										num = -14;
										goto IL_0B;
									}
									case 3:
									{
										bool flag;
										if (flag)
										{
											num = -12;
											goto IL_0B;
										}
										goto IL_116;
									}
									case 4:
										goto IL_113;
									}
									goto Block_1;
								case 2:
									goto IL_A1;
								case 3:
									break;
								default:
									num3 = Form2.uwpnsrqhswlmjh(34);
									continue;
								}
								IL_0B:
								num ^= 88;
								goto IL_4F;
							case 1:
								goto IL_4F;
							case 2:
							{
								RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form10.set_cmdUpdate(Button)).MethodHandle;
								num3 = -8;
								continue;
							}
							case 3:
								goto IL_6D;
							}
							break;
							IL_4F:
							num2 = Form12.wsyoqrrjsoniul(52);
							num3 = -7;
						}
					}
					IL_6D:
					continue;
					IL_6F:
					RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form10.get_cmdUpdate()).MethodHandle;
					num2 = -30;
					continue;
					Block_1:
					num2 = -32;
				}
			}
			IL_113:
			bool flag2 = false;
			goto IL_119;
			IL_116:
			flag2 = true;
			IL_119:
			if (!flag2)
			{
				this.rs.Delete(AffectEnum.adAffectCurrent);
				for (;;)
				{
					int num4 = Form2.uwpnsrqhswlmjh(50);
					for (;;)
					{
						num4 ^= 85;
						switch (num4 + 79)
						{
						case 0:
							this.refreshData();
							num4 = -30;
							continue;
						case 1:
							num4 = -19;
							continue;
						case 2:
							this.rs.Update(RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
							num4 = -32;
							continue;
						case 3:
							num4 = -20;
							continue;
						case 4:
							num4 = -28;
							continue;
						case 5:
						{
							RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form10.pdqangwdsoatpr(object, EventArgs)).MethodHandle;
							num4 = -29;
							continue;
						}
						case 6:
							num4 = Form2.uwpnsrqhswlmjh(47);
							continue;
						case 7:
							Interaction.MsgBox("Record Deleted Successfully.", MsgBoxStyle.Information, "Message");
							num4 = -26;
							continue;
						case 8:
							goto IL_226;
						}
						break;
					}
				}
				IL_226:;
			}
			else
			{
				Interaction.MsgBox("Record Not Deleted.", MsgBoxStyle.Information, "Message");
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000B814 File Offset: 0x00009A14
		private void pdqangwdsoatpw(object ah, EventArgs ai)
		{
			for (;;)
			{
				IL_29:
				int num = 18;
				int num2 = 14;
				for (;;)
				{
					switch (num2 ^ 91)
					{
					case 82:
						goto IL_29;
					case 83:
					{
						RuntimeMethodHandle runtimeMethodHandle = methodof(Form10.set_Label6(Label)).MethodHandle;
						num2 = 8;
						continue;
					}
					case 84:
						switch (num)
						{
						case 87:
						{
							bool @checked = this.rbMale.Checked;
							num = 17;
							goto IL_08;
						}
						case 88:
							this.rs.Fields["Title"].Value = this.cboTitle.Text;
							num = 47;
							goto IL_08;
						case 89:
							this.rs.Fields["DOB"].Value = this.DateTimePicker1.Value;
							num = 45;
							goto IL_08;
						case 90:
							num = 23;
							goto IL_08;
						case 91:
							num = 22;
							goto IL_08;
						case 92:
							this.rs.Fields["FirstName"].Value = this.txtFirstName.Text;
							num = 16;
							goto IL_08;
						case 93:
							this.rs.Fields["LecturerID"].Value = this.txtID.Text;
							num = 21;
							goto IL_08;
						case 94:
						{
							bool @checked;
							if (@checked)
							{
								num = 43;
								goto IL_08;
							}
							goto IL_1D4;
						}
						case 95:
							num = 44;
							goto IL_08;
						case 96:
							num = 19;
							goto IL_08;
						case 97:
						{
							RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form10.get_GroupBox1()).MethodHandle;
							num = 46;
							goto IL_08;
						}
						case 98:
							num = 24;
							goto IL_08;
						case 99:
							this.rs.Fields["LastName"].Value = this.txtLastName.Text;
							num = 20;
							goto IL_08;
						case 100:
							goto IL_1D1;
						default:
							num2 = 9;
							continue;
						}
						break;
					case 85:
						goto IL_08;
					}
					IL_23:
					num2 = 15;
					continue;
					IL_08:
					num ^= 79;
					goto IL_23;
				}
			}
			IL_1D1:
			bool flag = false;
			goto IL_1D7;
			IL_1D4:
			flag = true;
			IL_1D7:
			if (!flag)
			{
				this.rs.Fields["Gender"].Value = this.rbMale.Text;
				for (;;)
				{
					int num3 = 9;
					for (;;)
					{
						switch (num3 ^ 90)
						{
						case 83:
							num3 = 14;
							continue;
						case 84:
							num3 = 12;
							continue;
						case 85:
						{
							RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form10.set_cmdPrevious(Button)).MethodHandle;
							num3 = 15;
							continue;
						}
						case 86:
							goto IL_241;
						}
						break;
					}
				}
				IL_241:;
			}
			else
			{
				bool checked2 = this.rbFemale.Checked;
				if (checked2)
				{
					this.rs.Fields["Gender"].Value = this.rbFemale.Text;
				}
			}
			this.rs.Fields["School"].Value = this.cboSchool.Text;
			for (;;)
			{
				int num4 = Form12.wsyoqrrjsoniul(41);
				for (;;)
				{
					num4 ^= 92;
					switch (num4 + 87)
					{
					case 0:
						this.rs.Update(RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
						num4 = -14;
						continue;
					case 1:
						this.rs.Fields["Photo"].Value = this.str;
						num4 = -23;
						continue;
					case 2:
					{
						RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form10.pdqangwdsoatpp(object, EventArgs)).MethodHandle;
						num4 = -9;
						continue;
					}
					case 3:
						this.rs.Fields["Password"].Value = this.txtPassword.Text;
						num4 = -18;
						continue;
					case 4:
						Interaction.MsgBox("Record Updated Successfully.", MsgBoxStyle.Information, null);
						num4 = -11;
						continue;
					case 5:
						num4 = Form12.wsyoqrrjsoniul(43);
						continue;
					case 6:
						this.rs.Fields["PhoneNo"].Value = this.txtPhone.Text;
						num4 = -17;
						continue;
					case 7:
						this.rs.Fields["Email"].Value = this.txtEmail.Text;
						num4 = -19;
						continue;
					case 8:
						num4 = -10;
						continue;
					case 9:
						num4 = -15;
						continue;
					case 10:
						num4 = -20;
						continue;
					case 11:
						num4 = -13;
						continue;
					case 12:
						num4 = -16;
						continue;
					case 13:
						return;
					}
					break;
				}
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000BC80 File Offset: 0x00009E80
		private void pdqangwdsoatpx(object aj, EventArgs ak)
		{
			this.display();
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000BC90 File Offset: 0x00009E90
		private void pdqangwdsoatpy(object al, EventArgs am)
		{
			for (;;)
			{
				IL_C2:
				int num = 1;
				int num2 = Form12.wsyoqrrjsoniul(53);
				for (;;)
				{
					num2 ^= 91;
					for (;;)
					{
						IL_52:
						int num3 = 4;
						int num4 = Form12.wsyoqrrjsoniul(54);
						for (;;)
						{
							num4 ^= 86;
							switch (num4 + 81)
							{
							case 0:
							{
								RuntimeMethodHandle runtimeMethodHandle = methodof(Form10.set_cmdSearch(Button)).MethodHandle;
								num4 = -7;
								continue;
							}
							case 1:
								goto IL_52;
							case 2:
								switch (num3)
								{
								case 84:
									break;
								case 85:
									switch (num2 + 90)
									{
									case 0:
										goto IL_C2;
									case 1:
										goto IL_D1;
									case 2:
										switch (num)
										{
										case 85:
										{
											bool flag;
											if (flag)
											{
												num = 7;
												goto IL_0B;
											}
											goto IL_1A2;
										}
										case 86:
											num = 3;
											goto IL_0B;
										case 87:
										{
											bool flag = !this.rs.EOF;
											num = 14;
											goto IL_0B;
										}
										case 88:
											this.rs.Open("Select * from LecturersProfile where LecturerID = '" + this.txtID.Text + "'", this.con, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
											num = 2;
											goto IL_0B;
										case 89:
											num = 12;
											goto IL_0B;
										case 90:
											this.rs.Close();
											num = 13;
											goto IL_0B;
										case 91:
										{
											RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form10.get_Label5()).MethodHandle;
											num = 0;
											goto IL_0B;
										}
										case 92:
											goto IL_19F;
										}
										goto Block_3;
									case 3:
										break;
									default:
										num3 = 5;
										goto IL_1C;
									}
									IL_0B:
									num ^= 91;
									break;
								case 86:
								{
									RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form10.pdqangwdsoatpz(object, EventArgs)).MethodHandle;
									num3 = 7;
									goto IL_1C;
								}
								case 87:
									goto IL_BD;
								default:
									num4 = -26;
									continue;
								}
								num2 = Form7.mqgfoefwabbyeu(21);
								num3 = 6;
								goto IL_1C;
							case 3:
								goto IL_1C;
							}
							IL_37:
							num4 = Form2.uwpnsrqhswlmjh(50);
							continue;
							IL_1C:
							num3 ^= 81;
							goto IL_37;
						}
					}
					IL_BD:
					continue;
					IL_D1:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form10.set_cmdFirst(Button)).MethodHandle;
					num2 = -4;
					continue;
					Block_3:
					num2 = -3;
				}
			}
			IL_19F:
			bool flag2 = false;
			goto IL_1A5;
			IL_1A2:
			flag2 = true;
			IL_1A5:
			if (!flag2)
			{
				this.display();
				this.reload();
			}
			else
			{
				Interaction.MsgBox("Record Not Found.", MsgBoxStyle.Information, null);
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000BE9C File Offset: 0x0000A09C
		private void pdqangwdsoatpz(object an, EventArgs ao)
		{
			for (;;)
			{
				IL_BA:
				int num = Form6.sbdifomqugmuko(61);
				int num2 = 9;
				for (;;)
				{
					num2 ^= 92;
					for (;;)
					{
						IL_5B:
						int num3 = Form7.mqgfoefwabbyeu(25);
						int num4 = Form7.mqgfoefwabbyeu(24);
						for (;;)
						{
							num4 ^= 79;
							switch (num4 + 82)
							{
							case 0:
								switch (num3 + 91)
								{
								case 0:
								{
									RuntimeMethodHandle runtimeMethodHandle = methodof(Form10.set_cmdSearch(Button)).MethodHandle;
									num3 = -4;
									goto IL_1C;
								}
								case 1:
									switch (num2)
									{
									case 82:
										goto IL_AC;
									case 83:
										goto IL_BA;
									case 84:
										switch (num + 79)
										{
										case 0:
											num = -29;
											goto IL_0B;
										case 1:
										{
											RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form10.set_Label8(Label)).MethodHandle;
											num = -27;
											goto IL_0B;
										}
										case 2:
											num = Form2.uwpnsrqhswlmjh(47);
											goto IL_0B;
										case 3:
											yupufqwjlhlkfh.whvgmsxtmdbkxx.hcphoarosyelxe.Show();
											num = -28;
											goto IL_0B;
										case 4:
											base.Hide();
											num = -26;
											goto IL_0B;
										case 5:
											return;
										}
										goto Block_2;
									case 85:
										break;
									default:
										num3 = -2;
										goto IL_1C;
									}
									IL_0B:
									num ^= 87;
									break;
								case 2:
									break;
								case 3:
									goto IL_A7;
								default:
									num4 = -1;
									continue;
								}
								num2 = 8;
								num3 = Form7.mqgfoefwabbyeu(23);
								goto IL_1C;
							case 1:
							{
								RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form10.get_txtFirstName()).MethodHandle;
								num4 = -32;
								continue;
							}
							case 2:
								goto IL_5B;
							case 3:
								goto IL_1C;
							}
							IL_35:
							num4 = Form2.uwpnsrqhswlmjh(47);
							continue;
							IL_1C:
							num3 ^= 89;
							goto IL_35;
						}
					}
					IL_A7:
					continue;
					IL_AC:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form10.set_cmdUpdate(Button)).MethodHandle;
					num2 = 14;
					continue;
					Block_2:
					num2 = 15;
				}
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000C034 File Offset: 0x0000A234
		private void pdqangwdsoatqa(object ap, EventArgs aq)
		{
			for (;;)
			{
				IL_E6:
				int num = Form12.wsyoqrrjsoniul(49);
				int num2 = 10;
				for (;;)
				{
					num2 ^= 82;
					for (;;)
					{
						IL_4E:
						int num3 = Form6.sbdifomqugmuko(61);
						int num4 = -1;
						for (;;)
						{
							num4 ^= 81;
							switch (num4 + 85)
							{
							case 0:
							{
								RuntimeMethodHandle runtimeMethodHandle = methodof(Form10.pdqangwdsoatpq(object, EventArgs)).MethodHandle;
								num4 = -6;
								continue;
							}
							case 1:
								goto IL_4E;
							case 2:
								switch (num3 + 79)
								{
								case 0:
								{
									RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form10.get_cmdLast()).MethodHandle;
									num3 = -31;
									goto IL_1C;
								}
								case 1:
									switch (num2)
									{
									case 85:
										switch (num + 80)
										{
										case 0:
											this.txtPassword.Visible = true;
											num = -27;
											goto IL_0B;
										case 1:
											this.lblPassword.Visible = true;
											num = -29;
											goto IL_0B;
										case 2:
											num = -30;
											goto IL_0B;
										case 3:
										{
											RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form10.set_GroupBox2(GroupBox)).MethodHandle;
											num = -28;
											goto IL_0B;
										}
										case 4:
											num = -25;
											goto IL_0B;
										case 5:
											return;
										}
										goto Block_3;
									case 86:
										goto IL_E6;
									case 87:
										goto IL_F6;
									case 88:
										break;
									default:
										num3 = Form12.wsyoqrrjsoniul(52);
										goto IL_1C;
									}
									IL_0B:
									num ^= 87;
									break;
								case 2:
									break;
								case 3:
									goto IL_B9;
								default:
									num4 = -3;
									continue;
								}
								num2 = 7;
								num3 = -28;
								goto IL_1C;
							case 3:
								goto IL_1C;
							}
							IL_35:
							num4 = Form2.uwpnsrqhswlmjh(42);
							continue;
							IL_1C:
							num3 ^= 80;
							goto IL_35;
						}
					}
					IL_B9:
					continue;
					Block_3:
					num2 = 4;
					continue;
					IL_F6:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form10.get_Label8()).MethodHandle;
					num2 = 5;
				}
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000C1C8 File Offset: 0x0000A3C8
		internal static int pdqangwdsoatqb(int ar)
		{
			switch (ar - (~(-128 >> 1) << 4 >> 4))
			{
			case 0:
				return -617822736 + 617822609;
			case 2:
				return (-242182778 ^ -680364120) - 79331724 - 326137596 ^ -246933982;
			case 3:
				return 665392297 - 665392420;
			case 6:
				return --148720418 ^ -148720471;
			case 7:
				return ((468899254 - 4971924 << 1) + -145293828 >> 1) + -391280544;
			case 8:
				return (-264998431 ^ -477901721) + -330808829;
			case 9:
				return -(~(-(-240095322 + 240095443)));
			case 13:
				return ~(-(~-182050424 + -182050528));
			case 14:
				return ~(65527920 - -133282717 + -309436885 - -389400129) + 278773757;
			case 16:
				return ~((-677736342 + 502323644 >> 1) - -334283146) + 246576682;
			}
			return -64 >> 6;
		}

		// Token: 0x04000025 RID: 37
		private IContainer components;

		// Token: 0x0400004E RID: 78
		private Connection con;

		// Token: 0x0400004F RID: 79
		private Recordset rs;

		// Token: 0x04000050 RID: 80
		private string str;
	}
}
